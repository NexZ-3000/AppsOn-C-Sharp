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
            this.connectIPbutton.Location = new System.Drawing.Point(661, 1);
            this.connectIPbutton.Name = "connectIPbutton";
            this.connectIPbutton.Size = new System.Drawing.Size(127, 48);
            this.connectIPbutton.TabIndex = 0;
            this.connectIPbutton.Text = "Connect IP";
            this.connectIPbutton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(661, 248);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 42);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBox_ReceiveText
            // 
            this.tBox_ReceiveText.Location = new System.Drawing.Point(11, 350);
            this.tBox_ReceiveText.Name = "tBox_ReceiveText";
            this.tBox_ReceiveText.Size = new System.Drawing.Size(777, 22);
            this.tBox_ReceiveText.TabIndex = 2;
            this.tBox_ReceiveText.Text = "Here will be message from your friend";
            // 
            // tBox_SendText
            // 
            this.tBox_SendText.Location = new System.Drawing.Point(12, 258);
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
            // 
            // btnGetIp
            // 
            this.btnGetIp.Location = new System.Drawing.Point(661, 54);
            this.btnGetIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetIp.Name = "btnGetIp";
            this.btnGetIp.Size = new System.Drawing.Size(127, 38);
            this.btnGetIp.TabIndex = 5;
            this.btnGetIp.Text = "Get Ip";
            this.btnGetIp.UseVisualStyleBackColor = true;
            this.btnGetIp.Click += new System.EventHandler(this.btnGetIp_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnGetIp);
            this.Controls.Add(this.tBox_IpNum);
            this.Controls.Add(this.tBox_SendText);
            this.Controls.Add(this.tBox_ReceiveText);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectIPbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "ContactApp1";
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

