
namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chUserIP = new System.Windows.Forms.CheckBox();
            this.chUserPort = new System.Windows.Forms.CheckBox();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.chLocalHostIP = new System.Windows.Forms.CheckBox();
            this.lblConnectState = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecv = new System.Windows.Forms.ListBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.lblSentHeader = new System.Windows.Forms.Label();
            this.lblRecvHeader = new System.Windows.Forms.Label();
            this.lblLogHeader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            //
            // listBoxLog
            //
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(13, 490);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(560, 160);
            this.listBoxLog.TabIndex = 0;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.chUserIP);
            this.groupBox1.Controls.Add(this.chUserPort);
            this.groupBox1.Controls.Add(this.btnDisConn);
            this.groupBox1.Controls.Add(this.chLocalHostIP);
            this.groupBox1.Controls.Add(this.lblConnectState);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(560, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클라이언트 설정";
            //
            // chUserIP
            //
            this.chUserIP.AutoSize = true;
            this.chUserIP.Location = new System.Drawing.Point(300, 70);
            this.chUserIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chUserIP.Name = "chUserIP";
            this.chUserIP.Size = new System.Drawing.Size(89, 16);
            this.chUserIP.TabIndex = 14;
            this.chUserIP.Text = "UserIP 사용";
            this.chUserIP.UseVisualStyleBackColor = true;
            //
            // chUserPort
            //
            this.chUserPort.AutoSize = true;
            this.chUserPort.Location = new System.Drawing.Point(196, 70);
            this.chUserPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chUserPort.Name = "chUserPort";
            this.chUserPort.Size = new System.Drawing.Size(100, 16);
            this.chUserPort.TabIndex = 13;
            this.chUserPort.Text = "UserPort 사용";
            this.chUserPort.UseVisualStyleBackColor = true;
            //
            // btnDisConn
            //
            this.btnDisConn.Location = new System.Drawing.Point(475, 50);
            this.btnDisConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(70, 18);
            this.btnDisConn.TabIndex = 12;
            this.btnDisConn.Text = "접속 끊기";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.btnDisConn_Click);
            //
            // chLocalHostIP
            //
            this.chLocalHostIP.AutoSize = true;
            this.chLocalHostIP.Location = new System.Drawing.Point(82, 71);
            this.chLocalHostIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chLocalHostIP.Name = "chLocalHostIP";
            this.chLocalHostIP.Size = new System.Drawing.Size(108, 16);
            this.chLocalHostIP.TabIndex = 5;
            this.chLocalHostIP.Text = "LocalHost 사용";
            this.chLocalHostIP.UseVisualStyleBackColor = true;
            //
            // lblConnectState
            //
            this.lblConnectState.AutoSize = true;
            this.lblConnectState.Location = new System.Drawing.Point(137, 15);
            this.lblConnectState.Name = "lblConnectState";
            this.lblConnectState.Size = new System.Drawing.Size(69, 12);
            this.lblConnectState.TabIndex = 4;
            this.lblConnectState.Text = "서버 상태 : ";
            //
            // btnConnect
            //
            this.btnConnect.Location = new System.Drawing.Point(414, 50);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(55, 18);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "접속";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            //
            // txtPort
            //
            this.txtPort.Location = new System.Drawing.Point(285, 48);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(123, 21);
            this.txtPort.TabIndex = 3;
            //
            // txtIP
            //
            this.txtIP.Location = new System.Drawing.Point(82, 48);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(123, 21);
            this.txtIP.TabIndex = 2;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port 번호 : ";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "서버 주소 : ";
            //
            // lblSentHeader
            //
            this.lblSentHeader.AutoSize = false;
            this.lblSentHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSentHeader.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblSentHeader.Location = new System.Drawing.Point(13, 105);
            this.lblSentHeader.Name = "lblSentHeader";
            this.lblSentHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblSentHeader.Size = new System.Drawing.Size(559, 20);
            this.lblSentHeader.TabIndex = 30;
            this.lblSentHeader.Text = "전송 메시지";
            this.lblSentHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtSend
            //
            this.txtSend.Location = new System.Drawing.Point(13, 127);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(559, 152);
            this.txtSend.TabIndex = 20;
            //
            // lblRecvHeader
            //
            this.lblRecvHeader.AutoSize = false;
            this.lblRecvHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRecvHeader.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblRecvHeader.Location = new System.Drawing.Point(12, 285);
            this.lblRecvHeader.Name = "lblRecvHeader";
            this.lblRecvHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblRecvHeader.Size = new System.Drawing.Size(560, 20);
            this.lblRecvHeader.TabIndex = 31;
            this.lblRecvHeader.Text = "수신 메시지";
            this.lblRecvHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lstRecv
            //
            this.lstRecv.FormattingEnabled = true;
            this.lstRecv.ItemHeight = 12;
            this.lstRecv.Location = new System.Drawing.Point(12, 307);
            this.lstRecv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRecv.Name = "lstRecv";
            this.lstRecv.Size = new System.Drawing.Size(560, 152);
            this.lstRecv.TabIndex = 14;
            //
            // txtChat
            //
            this.txtChat.Location = new System.Drawing.Point(13, 465);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(499, 21);
            this.txtChat.TabIndex = 15;
            this.txtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyDown);
            //
            // btnSend
            //
            this.btnSend.Location = new System.Drawing.Point(517, 464);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(55, 22);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "전 송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            //
            // lblLogHeader
            //
            this.lblLogHeader.AutoSize = false;
            this.lblLogHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogHeader.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblLogHeader.Location = new System.Drawing.Point(13, 493);
            this.lblLogHeader.Name = "lblLogHeader";
            this.lblLogHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLogHeader.Size = new System.Drawing.Size(560, 20);
            this.lblLogHeader.TabIndex = 32;
            this.lblLogHeader.Text = "로그";
            this.lblLogHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // listBoxLog
            //
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(13, 515);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(560, 140);
            this.listBoxLog.TabIndex = 0;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 668);
            this.Controls.Add(this.lblSentHeader);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.lblRecvHeader);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lstRecv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLogHeader);
            this.Controls.Add(this.listBoxLog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "UserClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chLocalHostIP;
        private System.Windows.Forms.Label lblConnectState;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstRecv;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.ListBox listBoxLog;
        public System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.CheckBox chUserIP;
        private System.Windows.Forms.CheckBox chUserPort;
        private System.Windows.Forms.Label lblSentHeader;
        private System.Windows.Forms.Label lblRecvHeader;
        private System.Windows.Forms.Label lblLogHeader;
    }
}
