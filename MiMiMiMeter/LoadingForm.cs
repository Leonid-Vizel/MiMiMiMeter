using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

        private void LoadDataBase()
        {
            loading = true;
            loadedMetrics = new List<CatMetrics>();
            using (SQLiteConnection connection = new SQLiteConnection("DataSource='CatBase.db';Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Cats;",connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                loadedMetrics.Add(new CatMetrics(
                                    reader.GetInt32(0),
                                    reader.GetValue(1).ToString(),
                                    reader.GetInt32(2),
                                    reader.GetValue(3).ToString()));
                            }
                        }
                    }
                }
            }
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
