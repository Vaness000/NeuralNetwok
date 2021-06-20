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
