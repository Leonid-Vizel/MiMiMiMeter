using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MiMiMiMeter
{
    public partial class MainMiMiMi : Form
    {
        private BackgroundWorker imageLoader1;
        private BackgroundWorker imageLoader2;
        private List<CatMetrics> metricsCollection;

        public MainMiMiMi(List<CatMetrics> metricsCollection)
        {
            this.metricsCollection = metricsCollection;
            InitializeComponent();
            imageLoader1 = new BackgroundWorker();
            imageLoader1.DoWork += LoadImageAsync;
            imageLoader1.RunWorkerCompleted += Loaded;
            imageLoader2 = new BackgroundWorker();
            imageLoader2.DoWork += LoadImageAsync;
            imageLoader2.RunWorkerCompleted += Loaded;
        }

        private void Loaded(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingGifBox.Visible = (imageLoader1.IsBusy || imageLoader2.IsBusy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                LoadInfo(i+1, metricsCollection[i]);
            }
        }

        #region Another thread image loading  
        private void LoadInfo(int boxNumber, CatMetrics metrics)
        {
            loadingGifBox.Visible = true;
            if (imageLoader1.IsBusy)
            {
                imageLoader2.RunWorkerAsync(new Tuple<int, CatMetrics>(boxNumber, metrics));
            }
            else
            {
                imageLoader1.RunWorkerAsync(new Tuple<int, CatMetrics>(boxNumber, metrics));
            }
        }

        private void LoadImageAsync(object sender, DoWorkEventArgs e)
        {
            Tuple<int, CatMetrics> convertAgrument = e.Argument as Tuple<int, CatMetrics>;
            if (convertAgrument.Item1 == 1)
            {
                catPicture1.Image = convertAgrument.Item2.Image;
                catPicture1.Tag = convertAgrument.Item2;
                Action threadAction = () => { catName1.Text = $"{convertAgrument.Item2.Name} ({convertAgrument.Item2.Upvotes}👍🏻)"; };
                Invoke(threadAction);
            }
            else
            {
                catPicture2.Image = convertAgrument.Item2.Image;
                catPicture2.Tag = convertAgrument.Item2;
                Action threadAction = () => { catName2.Text = $"{convertAgrument.Item2.Name} ({convertAgrument.Item2.Upvotes}👍🏻)"; };
                Invoke(threadAction);
            }
        }
        #endregion

        private void ImageChosen(object sender, EventArgs e)
        {
            if (imageLoader1.IsBusy || imageLoader2.IsBusy)
            {
                MessageBox.Show("Изображение загружается. Подождите...","Ошибка");
                return;
            }
            PictureBox boxSender = sender as PictureBox;
            CatMetrics metrics = boxSender.Tag as CatMetrics;
            metrics.Chosen = true;
            (catPicture1.Tag as CatMetrics).Shown = true;
            (catPicture2.Tag as CatMetrics).Shown = true;
            CatMetrics next = metricsCollection.FirstOrDefault(x=>!x.Shown && x != metrics);
            if (next != null)
            {
                if (boxSender == catPicture1)
                {
                    LoadInfo(2,next);
                }
                else
                {
                    LoadInfo(1, metrics);
                    LoadInfo(2, next);
                }
            }
            else
            {
                Hide();
                StatisticsForm stats = new StatisticsForm(metricsCollection);
                stats.FormClosed += ClosingBugPrevention;
                stats.Show();
            }
        }

        private void ClosingBugPrevention(object sender, EventArgs e)
        {
            Close();
        }
    }
}
