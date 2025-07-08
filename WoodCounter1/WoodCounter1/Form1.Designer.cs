namespace WoodCounter1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Count/Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(455, 190);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(107, 22);
            this.tb3.TabIndex = 1;
            this.tb3.Text = "Итог деревьев";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(302, 190);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(127, 22);
            this.tb2.TabIndex = 2;
            this.tb2.Text = "Кол-во разрезов";
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Location = new System.Drawing.Point(12, 190);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(144, 22);
            this.tb1.TabIndex = 3;
            this.tb1.Text = "Кол-во деревьев (1)";
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Кол-во будет доступно позже/Tree count coming soon!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 340);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

