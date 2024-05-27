using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatClient
{
    class TcpHelper
    {
        public Socket sock = null;
        public string szErrorMsg;
        public TcpClient client;
        public NetworkStream stream;
        private byte[] buffer = new byte[1024];

        public event Action<string> MessageReceived;

        //소켓연결
        public bool Connect(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port);
                stream = client.GetStream();
                
                if (client == null || client.Connected == false)
                {
                    return false;
                }
                StartReading();
                return true;
            }
            catch (Exception ex)
            {
                Form1.form.AddMessage("서버에 연결할 수 없습니다: " + ex.Message, Form1.MessageType.Error);
                Close();
                return false;
            }
        }

        #region 메시지 Recv 동작 과정
        //1. 메시지 수신 준비 : StartReading 메서드가 비동기적으로 데이터를 읽기 시작
        //2. 메시지 수신 완료: 메시지를 수신하면 OnReadComplete 메서드가 호출
        //3. 이벤트 발생 : OnReadComplete 메서드에서 MessageReceived 이벤트 호출
        //4. 이벤트 핸들러 실행 : Form1 클래스에서 MessageReceived 이벤트에 등록된 OnMessageReceived 메서드가 실행
        //5. UI 업데이트 : OnMessageReceived 메서드에서 수신한 메시지를 텍스트 박스에 추가
        #endregion
        private void StartReading()
        {
            try
            {
                stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnReadComplete), null);
            }
            catch (Exception ex)
            {
                szErrorMsg = "Error Starting Read : " + ex.Message;
                Form1.form.AddMessage(szErrorMsg, Form1.MessageType.Error);
            }
        }

        private void OnReadComplete(IAsyncResult ar)
        {
            int bytesRead;
            try
            {
                bytesRead = stream.EndRead(ar);
            }
            catch(Exception ex)
            {
                szErrorMsg = "Error Reading From Stream : " + ex.Message;
                Form1.form.AddMessage(szErrorMsg, Form1.MessageType.Error);
                return;
            }

            if (bytesRead > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                MessageReceived?.Invoke(message);
            }

            StartReading();
        }

        //public void RecvMessage()
        //{
        //    while (true)
        //    {
        //        if (client.Connected)
        //        {
        //            try
        //            {
        //                int bytesRead = stream.Read(buffer, 0, buffer.Length);
        //                if (bytesRead <= 0) { continue; }

        //                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        //                Form1.form.AddMessage(message, Form1.MessageType.RecvMsg);
        //            }
        //            catch (Exception ex)
        //            {
        //                szErrorMsg = "메시지 수신 중 오류 발생 : " + ex.Message;
        //                Form1.form.AddMessage(szErrorMsg,Form1.MessageType.Log);
        //            }
        //        }
        //    }
        //}

        

        //스트림에 쓰기
        public void Send(string message)
        {
            try
            {
                // 보내는 데이터에 데이터 길이를 포함하는 새로운 데이터 생성하기
                string lengthPrefix = message.Length.ToString("D4");   // 4자리 길이 문자열로 변환
                string SendMessage = lengthPrefix + message;
                // ASCII 인코딩으로 바이트 배열로 변환
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(SendMessage);

                if (client != null && client.Connected) // 연결상태 유무 확인
                {
                    stream.Write(data, 0, data.Length);
                    Form1.form.AddMessage("Send : " + SendMessage, Form1.MessageType.SendMsg);
                }
                else
                {
                    Form1.form.AddMessage( "먼저 채팅서버에 접속해주세요", Form1.MessageType.Log);
                }
            }
            catch(SocketException se)
            {
                szErrorMsg = se.Message;
            }
        }

        //소켓과 스트림 닫기
        public void Close()
        {
            if (client != null && client.Connected)
            {
                client.Close();
            }
            if (stream != null) stream.Close();
        }

        public void ConnClose()
        {
            if (client != null) client.Close();
            if (stream != null) stream.Close();
        }
        
        public bool IsConnected() { return (client != null && client.Connected) ? true : false; }

    }
}
