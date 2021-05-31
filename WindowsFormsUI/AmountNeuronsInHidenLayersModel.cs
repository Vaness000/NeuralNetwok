using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUI
{
    public class AmountNeuronsInHidenLayersModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if(value == Amount)
                {
                    return;
                }
                else
                {
                    amount = value;
                    OnPropertyChanged(nameof(Amount));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
