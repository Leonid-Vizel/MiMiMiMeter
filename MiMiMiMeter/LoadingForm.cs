using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MiMiMiMeter
{
    public partial class LoadingForm : Form
    {
        private List<CatMetrics> loadedMetrics;
        private BackgroundWorker worker;
        private bool loading;
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadDataBase(object sender, DoWorkEventArgs e)
        {
            loading = true;
            loadedMetrics = new List<CatMetrics>();
            using (SQLiteConnection connection = new SQLiteConnection("DataSource='CatBase.db';Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Cats ORDER BY Upvotes DESC;", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            using (WebClient client = new WebClient())
                            {
                                while (reader.Read())
                                {
                                    using (Stream stream = client.OpenRead(reader.GetString(3)))
                                    {
                                        try
                                        {
                                            loadedMetrics.Add(new CatMetrics(
                                                    reader.GetInt32(0),
                                                    reader.GetString(1),
                                                    reader.GetInt32(2),
                                                    new Bitmap(stream)));
                                        }
                                        catch
                                        {
                                            continue;
                                        }
                                    }
                                }
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
                worker.CancelAsync();
            }
            Close();
        }

        private void OnShow(object sender, EventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += LoadDataBase;
            worker.RunWorkerAsync();
            worker.RunWorkerCompleted += (send, arg) =>
            {
                loading = false;
                MainMiMiMi form = new MainMiMiMi(loadedMetrics);
                form.FormClosed += ClosingBugPrevention;
                form.Show();
                Hide();
            };
        }
    }
}
