using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MiMiMiMeter
{
    public partial class LoadingForm : Form
    {
        private List<CatMetrics> loadedMetrics;
        private Thread loadTrd;
        private bool loading;
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            loadingGifBox.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Lightness_rotate_36f_cw.gif");
        }

        private void LoadDataBase()
        {
            loading = true;
            loadedMetrics = new List<CatMetrics>();
            //Далее должна быть реальная загрузка
            loadedMetrics.Add(new CatMetrics(0, "Муся", 0, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Felis_silvestris_silvestris.jpg/275px-Felis_silvestris_silvestris.jpg"));
            loadedMetrics.Add(new CatMetrics(1, "Сюся", 1, "https://n1s1.hsmedia.ru/b3/d6/5e/b3d65e364005217038eef6120ceee06a/728x485_1_a0a3c34a90f8bd0fea8374de8108ad93@2121x1414_0xac120003_8950190691634215775.jpeg"));
            loadedMetrics.Add(new CatMetrics(2, "Пуся", 2, "http://s1.fotokto.ru/photo/full/600/6008346.jpg"));
            loadedMetrics.Add(new CatMetrics(3, "Няся", 3, "https://photographers.ua/thumbnails/pictures/45124/800ximgp0715.jpg"));
        }

        private void ClosingBugPrevention(object sender, EventArgs e)
        {
            if (loading)
            {
                loadTrd.Abort();
            }
            Close();
        }

        private void OnShow(object sender, EventArgs e)
        {
            loadTrd = new Thread(new ThreadStart(LoadDataBase));
            loadTrd.Start();
            loadTrd.Join();
            loading = false;
            MainMiMiMi form = new MainMiMiMi(loadedMetrics);
            form.FormClosed += ClosingBugPrevention;
            form.Show();
            Hide();
        }
    }
}
