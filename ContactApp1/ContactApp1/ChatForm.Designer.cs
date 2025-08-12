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
            this.btnSend = new System.Windows.Forms.Button();
            this.tBox_ReceiveText = new System.Windows.Forms.TextBox();
            this.tBox_SendText = new System.Windows.Forms.TextBox();
            this.tBox_IpNum = new System.Windows.Forms.TextBox();
            this.btnGetIp = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(744, 128);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(143, 52);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tBox_ReceiveText
            // 
            this.tBox_ReceiveText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBox_ReceiveText.Location = new System.Drawing.Point(281, 188);
            this.tBox_ReceiveText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_ReceiveText.Multiline = true;
            this.tBox_ReceiveText.Name = "tBox_ReceiveText";
            this.tBox_ReceiveText.ReadOnly = true;
            this.tBox_ReceiveText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBox_ReceiveText.Size = new System.Drawing.Size(311, 325);
            this.tBox_ReceiveText.TabIndex = 2;
            this.tBox_ReceiveText.TextChanged += new System.EventHandler(this.tBox_ReceiveText_TextChanged);
            // 
            // tBox_SendText
            // 
            this.tBox_SendText.Location = new System.Drawing.Point(14, 152);
            this.tBox_SendText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_SendText.Name = "tBox_SendText";
            this.tBox_SendText.Size = new System.Drawing.Size(723, 26);
            this.tBox_SendText.TabIndex = 3;
            this.tBox_SendText.Text = "Enter your message after connect";
            // 
            // tBox_IpNum
            // 
            this.tBox_IpNum.Location = new System.Drawing.Point(14, 48);
            this.tBox_IpNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBox_IpNum.Name = "tBox_IpNum";
            this.tBox_IpNum.Size = new System.Drawing.Size(723, 26);
            this.tBox_IpNum.TabIndex = 4;
            this.tBox_IpNum.TextChanged += new System.EventHandler(this.tBox_IpNum_TextChanged);
            // 
            // btnGetIp
            // 
            this.btnGetIp.Location = new System.Drawing.Point(744, 70);
            this.btnGetIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetIp.Name = "btnGetIp";
            this.btnGetIp.Size = new System.Drawing.Size(143, 54);
            this.btnGetIp.TabIndex = 5;
            this.btnGetIp.Text = "Get Ip";
            this.btnGetIp.UseVisualStyleBackColor = true;
            this.btnGetIp.Click += new System.EventHandler(this.btnGetIp_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(744, 12);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(143, 51);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect IP";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "User";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm Nick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(744, 466);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 48);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear History";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(85, 26);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "NickName:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 14);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(112, 26);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "IP adress:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 188);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(120, 26);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Message box -->";
            // 
            // ChatForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 538);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.btnGetIp);
            this.Controls.Add(this.tBox_IpNum);
            this.Controls.Add(this.tBox_SendText);
            this.Controls.Add(this.tBox_ReceiveText);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "ContactMessenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tBox_ReceiveText;
        private System.Windows.Forms.TextBox tBox_SendText;
        private System.Windows.Forms.TextBox tBox_IpNum;
        private System.Windows.Forms.Button btnGetIp;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

