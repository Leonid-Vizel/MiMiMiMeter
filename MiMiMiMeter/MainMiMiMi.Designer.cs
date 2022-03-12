
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
            this.topLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGifBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // catPicture1
            // 
            this.catPicture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catPicture1.Location = new System.Drawing.Point(12, 3);
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
            this.catPicture2.Location = new System.Drawing.Point(353, 3);
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
            this.catName1.Location = new System.Drawing.Point(12, 306);
            this.catName1.Name = "catName1";
            this.catName1.Size = new System.Drawing.Size(300, 32);
            this.catName1.TabIndex = 3;
            this.catName1.Text = "[Кот-1]";
            this.catName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catName2
            // 
            this.catName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catName2.Location = new System.Drawing.Point(353, 306);
            this.catName2.Name = "catName2";
            this.catName2.Size = new System.Drawing.Size(300, 32);
            this.catName2.TabIndex = 4;
            this.catName2.Text = "[Кот-2]";
            this.catName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingGifBox
            // 
            this.loadingGifBox.Location = new System.Drawing.Point(305, 20);
            this.loadingGifBox.Name = "loadingGifBox";
            this.loadingGifBox.Size = new System.Drawing.Size(50, 50);
            this.loadingGifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGifBox.TabIndex = 5;
            this.loadingGifBox.TabStop = false;
            this.loadingGifBox.Visible = false;
            // 
            // topLabel
            // 
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(665, 57);
            this.topLabel.TabIndex = 6;
            this.topLabel.Text = "Кто Ми-ми-ми-шнее?)))";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.topLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 57);
            this.panel1.TabIndex = 7;
            // 
            // lowerPanel
            // 
            this.lowerPanel.Controls.Add(this.loadingGifBox);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 404);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(665, 76);
            this.lowerPanel.TabIndex = 8;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.catPicture1);
            this.mainPanel.Controls.Add(this.catPicture2);
            this.mainPanel.Controls.Add(this.catName1);
            this.mainPanel.Controls.Add(this.catName2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 57);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(665, 347);
            this.mainPanel.TabIndex = 9;
            // 
            // MainMiMiMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 480);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMiMiMi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мимимиметр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGifBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.lowerPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox catPicture1;
        private System.Windows.Forms.PictureBox catPicture2;
        private System.Windows.Forms.Label catName1;
        private System.Windows.Forms.Label catName2;
        private System.Windows.Forms.PictureBox loadingGifBox;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}

