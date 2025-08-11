namespace ContactApp1
{
    partial class ChatForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectIPbutton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.tBox_ReceiveText = new System.Windows.Forms.TextBox();
            this.tBox_SendText = new System.Windows.Forms.TextBox();
            this.tBox_IpNum = new System.Windows.Forms.TextBox();
            this.btnGetIp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectIPbutton
            // 
            this.connectIPbutton.Location = new System.Drawing.Point(744, 1);
            this.connectIPbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectIPbutton.Name = "connectIPbutton";
            this.connectIPbutton.Size = new System.Drawing.Size(143, 60);
            this.connectIPbutton.TabIndex = 0;
            this.connectIPbutton.Text = "Connect IP";
            this.connectIPbutton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(744, 310);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(143, 52);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBox_ReceiveText
            // 
            this.tBox_ReceiveText.Location = new System.Drawing.Point(12, 438);
            this.tBox_ReceiveText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_ReceiveText.Name = "tBox_ReceiveText";
            this.tBox_ReceiveText.Size = new System.Drawing.Size(874, 26);
            this.tBox_ReceiveText.TabIndex = 2;
            this.tBox_ReceiveText.Text = "Here will be message from your friend";
            // 
            // tBox_SendText
            // 
            this.tBox_SendText.Location = new System.Drawing.Point(14, 322);
            this.tBox_SendText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_SendText.Name = "tBox_SendText";
            this.tBox_SendText.Size = new System.Drawing.Size(723, 26);
            this.tBox_SendText.TabIndex = 3;
            this.tBox_SendText.Text = "Enter your message after connect";
            // 
            // tBox_IpNum
            // 
            this.tBox_IpNum.Location = new System.Drawing.Point(14, 18);
            this.tBox_IpNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_IpNum.Name = "tBox_IpNum";
            this.tBox_IpNum.Size = new System.Drawing.Size(723, 26);
            this.tBox_IpNum.TabIndex = 4;
            this.tBox_IpNum.Text = "Enter IP to connect";
            // 
            // btnGetIp
            // 
            this.btnGetIp.Location = new System.Drawing.Point(744, 68);
            this.btnGetIp.Name = "btnGetIp";
            this.btnGetIp.Size = new System.Drawing.Size(143, 48);
            this.btnGetIp.TabIndex = 5;
            this.btnGetIp.Text = "Get Ip";
            this.btnGetIp.UseVisualStyleBackColor = true;
            this.btnGetIp.Click += new System.EventHandler(this.btnGetIp_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnGetIp);
            this.Controls.Add(this.tBox_IpNum);
            this.Controls.Add(this.tBox_SendText);
            this.Controls.Add(this.tBox_ReceiveText);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectIPbutton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectIPbutton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox tBox_ReceiveText;
        private System.Windows.Forms.TextBox tBox_SendText;
        private System.Windows.Forms.TextBox tBox_IpNum;
        private System.Windows.Forms.Button btnGetIp;
    }
}

