using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkRealization
{
    [Serializable]
    public class Layer
    {
        private Neuron[] neurons;
        private double[] inputValues;


        public double[,] Weigths;
        public double[] OutputValues
        {
            get
            {
                return GetOutputValues();
            }
        }

        public Layer(int neuronsAmount, int prevousAmount, Func<double, double> activator, Random random)
        {
            Weigths = new double[prevousAmount, neuronsAmount];
            Weigths.RandomizeArray(random);
            neurons = new Neuron[neuronsAmount];
            for(int i = 0; i < neuronsAmount; i++)
            {
                neurons[i] = new Neuron(activator);
            }
        }
        public Layer()
        {

        }

        private double[] GetOutputValues()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                double[] d = Weigths.GetDimension(i);
                neurons[i].CalculateWeightedSum(Weigths.GetDimension(i), inputValues);
            }

            double[] result = new double[neurons.Length];
            for (int i = 0; i < neurons.Length; i++)
            {
                result[i] = neurons[i].OutputValue;
            }
            return result;
        }

        public void SetInputValues(double[] values)
        {
            Array.Copy(values, inputValues = new double[values.Length], values.Length);
        }
    }
}
