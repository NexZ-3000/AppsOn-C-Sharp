namespace ContactApp1
{
    partial class Form1
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
            this.connectIPbox = new System.Windows.Forms.TextBox();
            this.sendmessageBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // connectIPbox
            // 
            this.connectIPbox.Location = new System.Drawing.Point(12, 341);
            this.connectIPbox.Name = "connectIPbox";
            this.connectIPbox.Size = new System.Drawing.Size(776, 22);
            this.connectIPbox.TabIndex = 2;
            this.connectIPbox.Text = "Here will be message from your friend";
            // 
            // sendmessageBox
            // 
            this.sendmessageBox.Location = new System.Drawing.Point(12, 258);
            this.sendmessageBox.Name = "sendmessageBox";
            this.sendmessageBox.Size = new System.Drawing.Size(643, 22);
            this.sendmessageBox.TabIndex = 3;
            this.sendmessageBox.Text = "Enter your message after connect";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(643, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Enter IP to connect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.sendmessageBox);
            this.Controls.Add(this.connectIPbox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectIPbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectIPbutton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox connectIPbox;
        private System.Windows.Forms.TextBox sendmessageBox;
        private System.Windows.Forms.TextBox textBox3;
    }
}

