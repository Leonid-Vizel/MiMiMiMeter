
namespace MiMiMiMeter
{
    partial class MainMiMiMi
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
            this.catPicture1 = new System.Windows.Forms.PictureBox();
            this.catPicture2 = new System.Windows.Forms.PictureBox();
            this.catName1 = new System.Windows.Forms.Label();
            this.catName2 = new System.Windows.Forms.Label();
            this.loadingGifBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGifBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catPicture1
            // 
            this.catPicture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catPicture1.Location = new System.Drawing.Point(12, 12);
            this.catPicture1.Name = "catPicture1";
            this.catPicture1.Size = new System.Drawing.Size(300, 300);
            this.catPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPicture1.TabIndex = 1;
            this.catPicture1.TabStop = false;
            this.catPicture1.Click += new System.EventHandler(this.ImageChosen);
            // 
            // catPicture2
            // 
            this.catPicture2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catPicture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catPicture2.Location = new System.Drawing.Point(353, 12);
            this.catPicture2.Name = "catPicture2";
            this.catPicture2.Size = new System.Drawing.Size(300, 300);
            this.catPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPicture2.TabIndex = 2;
            this.catPicture2.TabStop = false;
            this.catPicture2.Click += new System.EventHandler(this.ImageChosen);
            // 
            // catName1
            // 
            this.catName1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catName1.Location = new System.Drawing.Point(12, 315);
            this.catName1.Name = "catName1";
            this.catName1.Size = new System.Drawing.Size(300, 32);
            this.catName1.TabIndex = 3;
            this.catName1.Text = "[Кот-1]";
            this.catName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catName2
            // 
            this.catName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catName2.Location = new System.Drawing.Point(353, 315);
            this.catName2.Name = "catName2";
            this.catName2.Size = new System.Drawing.Size(300, 32);
            this.catName2.TabIndex = 4;
            this.catName2.Text = "[Кот-2]";
            this.catName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingGifBox
            // 
            this.loadingGifBox.Location = new System.Drawing.Point(305, 388);
            this.loadingGifBox.Name = "loadingGifBox";
            this.loadingGifBox.Size = new System.Drawing.Size(50, 50);
            this.loadingGifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGifBox.TabIndex = 5;
            this.loadingGifBox.TabStop = false;
            this.loadingGifBox.Visible = false;
            // 
            // MainMiMiMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.loadingGifBox);
            this.Controls.Add(this.catName2);
            this.Controls.Add(this.catName1);
            this.Controls.Add(this.catPicture2);
            this.Controls.Add(this.catPicture1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMiMiMi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мимимиметр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGifBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox catPicture1;
        private System.Windows.Forms.PictureBox catPicture2;
        private System.Windows.Forms.Label catName1;
        private System.Windows.Forms.Label catName2;
        private System.Windows.Forms.PictureBox loadingGifBox;
    }
}

