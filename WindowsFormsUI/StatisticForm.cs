using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class StatisticForm : Form
    {
        public StatisticForm(Dictionary<long, double> values, double time, long iterations)
        {
            InitializeComponent();
            int i = 50;
            foreach(var value in values)
            {
                    chart1.Series[0].Points.AddXY(value.Key, value.Value);
            }
            chart1.ChartAreas[0].AxisY.IsLogarithmic = true;

            iterationsLabel.Text = string.Format("Итераций генетического алгоритма: {0}", iterations);
            timeLabel.Text = string.Format("Время на обучение: {0} миллисекунд ({1} секунд)", Math.Round(time, 2), Math.Round(time / 1000, 2));
        }
    }
}
