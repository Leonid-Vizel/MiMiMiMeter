using System;
using System.Collections.Generic;
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
            foreach (CatMetrics metrics in metricsCollection)
            {
                if (metrics.Chosen)
                {
                    metrics.Upvotes++;
                }
            }
            catList.Items.AddRange(metricsCollection.ToArray());
        }
    }
}
