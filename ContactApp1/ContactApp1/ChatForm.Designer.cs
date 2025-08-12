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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.sendButton = new System.Windows.Forms.Button();
            this.tBox_ReceiveText = new System.Windows.Forms.TextBox();
            this.tBox_SendText = new System.Windows.Forms.TextBox();
            this.tBox_IpNum = new System.Windows.Forms.TextBox();
            this.btnGetIp = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(661, 87);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 42);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBox_ReceiveText
            // 
            this.tBox_ReceiveText.Location = new System.Drawing.Point(254, 125);
            this.tBox_ReceiveText.Multiline = true;
            this.tBox_ReceiveText.Name = "tBox_ReceiveText";
            this.tBox_ReceiveText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBox_ReceiveText.Size = new System.Drawing.Size(277, 261);
            this.tBox_ReceiveText.TabIndex = 2;
            this.tBox_ReceiveText.Text = "Here will be message from your friend";
            this.tBox_ReceiveText.TextChanged += new System.EventHandler(this.tBox_ReceiveText_TextChanged);
            // 
            // tBox_SendText
            // 
            this.tBox_SendText.Location = new System.Drawing.Point(12, 97);
            this.tBox_SendText.Name = "tBox_SendText";
            this.tBox_SendText.Size = new System.Drawing.Size(643, 22);
            this.tBox_SendText.TabIndex = 3;
            this.tBox_SendText.Text = "Enter your message after connect";
            // 
            // tBox_IpNum
            // 
            this.tBox_IpNum.Location = new System.Drawing.Point(12, 14);
            this.tBox_IpNum.Name = "tBox_IpNum";
            this.tBox_IpNum.Size = new System.Drawing.Size(643, 22);
            this.tBox_IpNum.TabIndex = 4;
            this.tBox_IpNum.Text = "Enter IP to connect";
            this.tBox_IpNum.TextChanged += new System.EventHandler(this.tBox_IpNum_TextChanged);
            // 
            // btnGetIp
            // 
            this.btnGetIp.Location = new System.Drawing.Point(661, 44);
            this.btnGetIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetIp.Name = "btnGetIp";
            this.btnGetIp.Size = new System.Drawing.Size(127, 43);
            this.btnGetIp.TabIndex = 5;
            this.btnGetIp.Text = "Get Ip";
            this.btnGetIp.UseVisualStyleBackColor = true;
            this.btnGetIp.Click += new System.EventHandler(this.btnGetIp_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(661, 7);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(127, 37);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect IP";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Enter NickName";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm Nick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.btnGetIp);
            this.Controls.Add(this.tBox_IpNum);
            this.Controls.Add(this.tBox_SendText);
            this.Controls.Add(this.tBox_ReceiveText);
            this.Controls.Add(this.sendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "ContactMessenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox tBox_ReceiveText;
        private System.Windows.Forms.TextBox tBox_SendText;
        private System.Windows.Forms.TextBox tBox_IpNum;
        private System.Windows.Forms.Button btnGetIp;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

