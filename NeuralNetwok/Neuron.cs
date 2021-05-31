using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkRealization
{
    [Serializable]
    public class Neuron
    {
        private double weightedSum;
        private Func<double, double> activator;
        public double OutputValue 
        {
            get
            {
                return activator(weightedSum);
            }
        }

        public Neuron(Func<double, double> activator)
        {
            this.activator = activator;
        }
        public Neuron() { }

        public void CalculateWeightedSum(double[] weights, double[] values)
        {
            weightedSum = 0;
            for(int i = 0; i < weights.Length; i++)
            {
                weightedSum += weights[i] * values[i];
            }
        }
    }
}
