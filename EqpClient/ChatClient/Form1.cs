using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Serilog;
namespace ChatClient
{
    public partial class Form1 : Form
    {

        //OracleDBHelper OracleDB = new OracleDBHelper("XE", "192.168.10.230", "1521", "ACETECH", "acetech");

        TcpHelper Network = new TcpHelper();

        public static Form1 form;
        public Form1()
        {
            form = this;
            InitializeComponent();
            // Event를 구독하는 구문 Network 객체의 MessageReceived 이벤트가 발생할 때 'OnMessageReceived' 메서드가 호출
            Network.MessageReceived += OnMessageReceived;
        }

        public enum MessageType
        {
            SendMsg,
            RecvMsg,
            Error,
            Log
        }

        // 접속 버튼
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string address = txtIP.Text;

            if (chLocalHostIP.Checked == true)
            {
                address = "127.0.0.1";
                txtIP.Text = "127.0.0.1";
            }

            if(chUserIP.Checked == true)
            {
                address = "192.168.10.230";
                txtIP.Text = "192.168.10.230";
            }

            if (chUserPort.Checked == true)
            {
                txtPort.Text = "32452";
            }

            int port = Convert.ToInt32(txtPort.Text);

            AddMessage($"서버에 접속 시도 : IP : {address}, Port : {port}", MessageType.Log);
            if (Network.Connect(address, port))
            {
                lblConnectState.Text = string.Format("{0}. 서버에 접속 중", DateTime.Now);
                //Thread RecvThread = new Thread(new ThreadStart(Network.RecvMessage));
                //RecvThread.IsBackground = true;
                //RecvThread.Start();
            }
            else
            {
                lblConnectState.Text = string.Format("{0}. 서버에 접속 실패", DateTime.Now);
            }
        }

        //접속 끊기 버튼
        private void btnDisConn_Click(object sender, EventArgs e)
        {
            AddMessage($"서버 접속 끊기", MessageType.Log);
            Network.Close();
        }

        // 채팅 전송
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtChat.Text;
            Network.Send(message);

            // 메시지 전송 후 텍스트 상자 지우기
            txtChat.Clear();
        }

        public void AddMessage(string message, MessageType messageType)
        {
            string TimeStemp = $"{DateTime.Now:[yyyy-MM-dd HH:mm:ss]}";
            switch (messageType)
            {
                case MessageType.SendMsg:
                    if (txtSend.InvokeRequired)
                    {
                        // 다른 스레드에서 실행 중이므로 Invoke를 사용하여 UI 스레드에서 실행
                        // delegate는 메서드의 참조를 저장하고 호출할 수 있는 개체
                        txtSend.Invoke(new MethodInvoker(delegate { AddMessage(message, MessageType.SendMsg); }));
                        return;
                    }
                    txtSend.AppendText(TimeStemp + " " + message + Environment.NewLine);
                    Log.Information("Send : " + message);

                    break;

                case MessageType.RecvMsg:
                    if (lstRecv.InvokeRequired)
                    {
                        // 다른 스레드에서 실행 중이므로 Invoke를 사용하여 UI 스레드에서 실행
                        // delegate는 메서드의 참조를 저장하고 호출할 수 있는 개체
                        lstRecv.Invoke(new MethodInvoker(delegate { AddMessage(message, MessageType.RecvMsg); }));
                        return;
                    }
                    lstRecv.Items.Add(TimeStemp + " Recv : " + message + Environment.NewLine);
                    Log.Information("Recv : " + message);
                    break;

                case MessageType.Error:
                    if (listBoxLog.InvokeRequired)
                    {
                        // 다른 스레드에서 실행 중이므로 Invoke를 사용하여 UI 스레드에서 실행
                        // delegate는 메서드의 참조를 저장하고 호출할 수 있는 개체
                        listBoxLog.Invoke(new MethodInvoker(delegate { AddMessage(message, MessageType.Log); }));
                        return;
                    }

                    listBoxLog.Items.Add(TimeStemp + " " + message + Environment.NewLine);
                    Log.Error(message);
                    break;

                case MessageType.Log:
                    if (listBoxLog.InvokeRequired)
                    {
                        // 다른 스레드에서 실행 중이므로 Invoke를 사용하여 UI 스레드에서 실행
                        // delegate는 메서드의 참조를 저장하고 호출할 수 있는 개체
                        listBoxLog.Invoke(new MethodInvoker(delegate { AddMessage(message, MessageType.Log); }));
                        return;
                    }

                    listBoxLog.Items.Add(TimeStemp + " " + message + Environment.NewLine);
                    Log.Information(message);
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 폼이 닫힐 때 연결 해제
            Network.ConnClose();
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnSend_Click(sender, e);
        }

        private void OnMessageReceived(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(OnMessageReceived), message);
                return;
            }
            AddMessage(message, MessageType.RecvMsg);
        }
    }
}
