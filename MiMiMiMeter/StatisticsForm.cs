using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MiMiMiMeter
{
    public partial class StatisticsForm : Form
    {
        private List<CatMetrics> metricsCollection;

        public StatisticsForm(List<CatMetrics> metricsCollection)
        {
            this.metricsCollection = metricsCollection;
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("DataSource='CatBase.db';Version=3;"))
            {
                connection.Open();
                foreach (CatMetrics metrics in metricsCollection)
                {
                    if (metrics.Chosen)
                    {
                        metrics.Upvotes++;
                        using (SQLiteCommand command = new SQLiteCommand($"UPDATE Cats SET Upvotes = {metrics.Upvotes} WHERE Id = {metrics.Id};", connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    catList.Items.Add(metrics);
                }
            }
        }
    }
}
