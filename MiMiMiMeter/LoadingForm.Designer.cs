
namespace MiMiMiMeter
{
    partial class LoadingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadingGifBox = new System.Windows.Forms.PictureBox();
            this.loadingInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGifBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingGifBox
            // 
            this.loadingGifBox.Location = new System.Drawing.Point(12, 12);
            this.loadingGifBox.Name = "loadingGifBox";
            this.loadingGifBox.Size = new System.Drawing.Size(300, 300);
            this.loadingGifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGifBox.TabIndex = 0;
            this.loadingGifBox.TabStop = false;
            // 
            // loadingInfoLabel
            // 
            this.loadingInfoLabel.Location = new System.Drawing.Point(12, 315);
            this.loadingInfoLabel.Name = "loadingInfoLabel";
            this.loadingInfoLabel.Size = new System.Drawing.Size(300, 32);
            this.loadingInfoLabel.TabIndex = 1;
            this.loadingInfoLabel.Text = "label1";
            this.loadingInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 356);
            this.Controls.Add(this.loadingInfoLabel);
            this.Controls.Add(this.loadingGifBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка...";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.OnShow);
            ((System.ComponentModel.ISupportInitialize)(this.loadingGifBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loadingGifBox;
        private System.Windows.Forms.Label loadingInfoLabel;
    }
}