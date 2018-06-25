namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adding = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reverse = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.HalfPow = new System.Windows.Forms.Button();
            this.Divine = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 38);
            this.textBox1.MaxLength = 4000000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ввод данных";
            // 
            // Adding
            // 
            this.Adding.BackColor = System.Drawing.Color.DeepPink;
            this.Adding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adding.Location = new System.Drawing.Point(30, 31);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(75, 23);
            this.Adding.TabIndex = 8;
            this.Adding.Text = "+";
            this.Adding.UseVisualStyleBackColor = false;
            this.Adding.Click += new System.EventHandler(this.Adding_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(159, 119);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 23);
            this.Result.TabIndex = 9;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.Turquoise;
            this.Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(159, 31);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 10;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.BackColor = System.Drawing.Color.Blue;
            this.Mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul.Location = new System.Drawing.Point(30, 61);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 23);
            this.Mul.TabIndex = 11;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = false;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.Reverse);
            this.groupBox1.Controls.Add(this.Cos);
            this.groupBox1.Controls.Add(this.HalfPow);
            this.groupBox1.Controls.Add(this.Divine);
            this.groupBox1.Controls.Add(this.Mul);
            this.groupBox1.Controls.Add(this.Sub);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.Adding);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox1.Location = new System.Drawing.Point(33, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные кнопки";
            // 
            // Reverse
            // 
            this.Reverse.BackColor = System.Drawing.Color.OrangeRed;
            this.Reverse.Location = new System.Drawing.Point(30, 118);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(75, 23);
            this.Reverse.TabIndex = 15;
            this.Reverse.Text = "1/x";
            this.Reverse.UseVisualStyleBackColor = false;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.Color.Pink;
            this.Cos.Location = new System.Drawing.Point(159, 90);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 14;
            this.Cos.Text = "Cos(x)";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // HalfPow
            // 
            this.HalfPow.BackColor = System.Drawing.Color.Crimson;
            this.HalfPow.Location = new System.Drawing.Point(30, 91);
            this.HalfPow.Name = "HalfPow";
            this.HalfPow.Size = new System.Drawing.Size(75, 23);
            this.HalfPow.TabIndex = 13;
            this.HalfPow.Text = "1^1/2";
            this.HalfPow.UseVisualStyleBackColor = false;
            this.HalfPow.Click += new System.EventHandler(this.HalfPow_Click);
            // 
            // Divine
            // 
            this.Divine.BackColor = System.Drawing.Color.Lime;
            this.Divine.Location = new System.Drawing.Point(159, 60);
            this.Divine.Name = "Divine";
            this.Divine.Size = new System.Drawing.Size(75, 23);
            this.Divine.TabIndex = 12;
            this.Divine.Text = "/";
            this.Divine.UseVisualStyleBackColor = false;
            this.Divine.Click += new System.EventHandler(this.Divine_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Pink;
            this.Error.ForeColor = System.Drawing.Color.Black;
            this.Error.Location = new System.Drawing.Point(45, 65);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 13;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkRed;
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Location = new System.Drawing.Point(349, 26);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(106, 35);
            this.Close.TabIndex = 14;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.Clear.Location = new System.Drawing.Point(349, 100);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 35);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Подсказка: Пределы вводимых чисел от -2000000 до 4000000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Divine;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button HalfPow;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label2;

    }
}

