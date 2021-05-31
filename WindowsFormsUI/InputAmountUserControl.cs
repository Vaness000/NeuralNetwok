using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class InputAmountUserControl : UserControl
    {
        public int Amount 
        { 
            get
            {
                return layersModel.Amount;
            }
        }
        private AmountNeuronsInHidenLayersModel layersModel;

        public InputAmountUserControl(int numberOfLayer, AmountNeuronsInHidenLayersModel layersModel)
        {
            InitializeComponent();
            this.layersModel = layersModel;
            numberOfLayerLabel.Text = string.Format("Количество нейронов в {0} скрытом слое", numberOfLayer);
            neuronsAmount.DataBindings.Add(nameof(NumericUpDown.Value), layersModel,
                nameof(layersModel.Amount), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
