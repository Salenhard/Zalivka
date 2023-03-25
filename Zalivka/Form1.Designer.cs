namespace Zalivka
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
            this.buttonPouring = new System.Windows.Forms.Button();
            this.buttonFether = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonPouring
            // 
            this.buttonPouring.Location = new System.Drawing.Point(12, 12);
            this.buttonPouring.Name = "buttonPouring";
            this.buttonPouring.Size = new System.Drawing.Size(97, 23);
            this.buttonPouring.TabIndex = 1;
            this.buttonPouring.Text = "Заливка";
            this.buttonPouring.UseVisualStyleBackColor = true;
            this.buttonPouring.Click += new System.EventHandler(this.buttonPouring_Click);
            // 
            // buttonFether
            // 
            this.buttonFether.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFether.Location = new System.Drawing.Point(12, 41);
            this.buttonFether.Name = "buttonFether";
            this.buttonFether.Size = new System.Drawing.Size(97, 23);
            this.buttonFether.TabIndex = 3;
            this.buttonFether.Text = "Перо";
            this.buttonFether.UseVisualStyleBackColor = true;
            this.buttonFether.Click += new System.EventHandler(this.buttonFether_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.Location = new System.Drawing.Point(13, 70);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonFether);
            this.Controls.Add(this.buttonPouring);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPouring;
        private System.Windows.Forms.Button buttonFether;
        private System.Windows.Forms.Button buttonClear;
    }
}

