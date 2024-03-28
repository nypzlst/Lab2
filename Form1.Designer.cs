namespace Lab2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxRect1X = new System.Windows.Forms.TextBox();
            this.textBoxRect1Y = new System.Windows.Forms.TextBox();
            this.textBoxRect1Width = new System.Windows.Forms.TextBox();
            this.textBoxRect1Height = new System.Windows.Forms.TextBox();
            this.textBoxRect2X = new System.Windows.Forms.TextBox();
            this.textBoxRect2Y = new System.Windows.Forms.TextBox();
            this.textBoxRect2Width = new System.Windows.Forms.TextBox();
            this.textBoxRect2Height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBoxRect1X
            // 
            this.textBoxRect1X.Location = new System.Drawing.Point(148, 284);
            this.textBoxRect1X.Name = "textBoxRect1X";
            this.textBoxRect1X.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect1X.TabIndex = 2;
            // 
            // textBoxRect1Y
            // 
            this.textBoxRect1Y.Location = new System.Drawing.Point(148, 313);
            this.textBoxRect1Y.Name = "textBoxRect1Y";
            this.textBoxRect1Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect1Y.TabIndex = 3;
            // 
            // textBoxRect1Width
            // 
            this.textBoxRect1Width.Location = new System.Drawing.Point(148, 343);
            this.textBoxRect1Width.Name = "textBoxRect1Width";
            this.textBoxRect1Width.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect1Width.TabIndex = 4;
            // 
            // textBoxRect1Height
            // 
            this.textBoxRect1Height.Location = new System.Drawing.Point(148, 369);
            this.textBoxRect1Height.Name = "textBoxRect1Height";
            this.textBoxRect1Height.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect1Height.TabIndex = 5;
            // 
            // textBoxRect2X
            // 
            this.textBoxRect2X.Location = new System.Drawing.Point(451, 284);
            this.textBoxRect2X.Name = "textBoxRect2X";
            this.textBoxRect2X.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect2X.TabIndex = 6;
            // 
            // textBoxRect2Y
            // 
            this.textBoxRect2Y.Location = new System.Drawing.Point(451, 313);
            this.textBoxRect2Y.Name = "textBoxRect2Y";
            this.textBoxRect2Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect2Y.TabIndex = 7;
            // 
            // textBoxRect2Width
            // 
            this.textBoxRect2Width.Location = new System.Drawing.Point(451, 343);
            this.textBoxRect2Width.Name = "textBoxRect2Width";
            this.textBoxRect2Width.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect2Width.TabIndex = 8;
            // 
            // textBoxRect2Height
            // 
            this.textBoxRect2Height.Location = new System.Drawing.Point(451, 369);
            this.textBoxRect2Height.Name = "textBoxRect2Height";
            this.textBoxRect2Height.Size = new System.Drawing.Size(100, 20);
            this.textBoxRect2Height.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Х 1 прямокутника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Х 2 прямокутника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y 1 прямокутника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y 2 прямокутника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ширина 1 прямокутника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ширина 2 прямокутника";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Висота 1 прямокутника";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Висота 2 прямокутника";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRect2Height);
            this.Controls.Add(this.textBoxRect2Width);
            this.Controls.Add(this.textBoxRect2Y);
            this.Controls.Add(this.textBoxRect2X);
            this.Controls.Add(this.textBoxRect1Height);
            this.Controls.Add(this.textBoxRect1Width);
            this.Controls.Add(this.textBoxRect1Y);
            this.Controls.Add(this.textBoxRect1X);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxRect1X;
        private System.Windows.Forms.TextBox textBoxRect1Y;
        private System.Windows.Forms.TextBox textBoxRect1Width;
        private System.Windows.Forms.TextBox textBoxRect1Height;
        private System.Windows.Forms.TextBox textBoxRect2X;
        private System.Windows.Forms.TextBox textBoxRect2Y;
        private System.Windows.Forms.TextBox textBoxRect2Width;
        private System.Windows.Forms.TextBox textBoxRect2Height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

