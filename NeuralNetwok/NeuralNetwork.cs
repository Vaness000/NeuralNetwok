using GeneticAlgorithmRealization;
using Manager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using Activator = Manager.Activator;

namespace NeuralNetworkRealization
{
    [Serializable]
    public class NeuralNetwork
    {
        private object max = Convert.ToDouble(ConfigurationManager.AppSettings.Get("Maximum"));
        private Layer[] layers;
        private string activatorTitle;
        public int amount;
        public double[] Solution
        {
            get
            {
                return layers.Last().OutputValues;
            }
        }

        public int Inputs { get; private set; }
        public int Outputs { get; private set; }

        public Dictionary<long, double> Statistic { get; private set; }

        public NeuralNetwork(int inputNeuronsAmount, int[] neuronsInLayers, Manager.Activator activator)//
        {
            Random random = new Random();
            layers = new Layer[neuronsInLayers.Length];
            layers[0] = new Layer(neuronsInLayers[0], inputNeuronsAmount, activator.ActivationFunc, random);
            for(int i = 1; i < neuronsInLayers.Length; i++)
            {
                layers[i] = new Layer(neuronsInLayers[i], neuronsInLayers[i - 1], activator.ActivationFunc, random);
            }

            activatorTitle = activator.TitleFunc;
            Inputs = inputNeuronsAmount;
            Outputs = neuronsInLayers.Last();
        }
        public NeuralNetwork() { }

        public void Traverse(double[] inputValues)
        {
            double[] temp = inputValues.Select(x => x / (double)max).ToArray();
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].SetInputValues(temp);
                temp = layers[i].OutputValues;
            } 
        }

        public double[] GetChromosome()
        {
            int length = GetChromosomeLength();

            double[] chromosome = new double[length];

            int index = 0;
            for (int i = 0; i < layers.Length; i++)
            {
                for (int j = 0; j < layers[i].Weigths.GetRows(); j++)
                {
                    for (int k = 0; k < layers[i].Weigths.GetColumns(); k++)
                    {
                        chromosome[index++] = layers[i].Weigths[j, k];
                    }
                }
            }

            return chromosome;
        }

        private int GetChromosomeLength()
        {
            int length = 0;
            foreach (Layer layer in layers)
            {
                length += layer.Weigths.GetRows() * layer.Weigths.GetColumns();
            }

            return length;
        }

        public void SetWeightsFromChromosome(double[] genes)
        {
            int index = 0;
            for (int i = 0; i < layers.Length; i++)
            {
                for (int j = 0; j < layers[i].Weigths.GetRows(); j++)
                {
                    for (int k = 0; k < layers[i].Weigths.GetColumns(); k++)
                    {
                        layers[i].Weigths[j, k] = genes[index++];
                    }
                }
            }
        }

        public void Train(List<double[]> inputValues, List<double[]> solutions, double eps, int populationAmount, int maxIterations, double mutationPropability)
        {
            int genesAmount = GetChromosomeLength();
            GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm(genesAmount, populationAmount, eps, maxIterations, mutationPropability);
            List<double[]> currentSolutions = new List<double[]>();

            while (!geneticAlgorithm.HasSolution)
            {
                amount++;
                for (int j = 0; j < geneticAlgorithm.Population.Count; j++)
                {
                    SetWeightsFromChromosome(geneticAlgorithm.Population[j].Genes);
                    currentSolutions.Clear();

                    for (int i = 0; i < inputValues.Count; i++)
                    {
                        Traverse(inputValues[i]);
                        currentSolutions.Add(Solution);
                    }

                    geneticAlgorithm.Population[j].CalculateFitness
                        (currentSolutions.GetArrayFromListOfArrays(), solutions.GetArrayFromListOfArrays());
                }

                geneticAlgorithm.MakeGeneration();
            }

            this.Statistic = geneticAlgorithm.Statistic;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double[] weights = GetChromosome();
            foreach(double weight in weights)
            {
                sb.Append(string.Format("{0} ", weight));
            }

            sb.Append("\n");

            sb.Append(string.Format("{0} ", layers[0].Weigths.GetRows()));

            foreach(Layer layer in layers)
            {
                sb.Append(string.Format("{0} ", layer.Weigths.GetColumns()));
            }

            sb.Append("\n");
            sb.Append(activatorTitle);

            return sb.ToString();
        }

        public static NeuralNetwork CreateNeuralNetwork(string description)
        {
            string[] information = description.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            double[] weights = information[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ConvertSequenseToDouble().ToArray();
            int[] layers = information[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ConvertSequenseToInt().ToArray();
            Activator activator = ActivatorsList.GetActivators().First(x => x.TitleFunc == information[2]);

            NeuralNetwork neuralNetwork = new NeuralNetwork(layers[0], layers.Skip(1).ToArray(), activator);
            neuralNetwork.SetWeightsFromChromosome(weights);

            return neuralNetwork;
        }

        public void SaveToFile(string path)
        {
            File.WriteAllText(path, ToString());
        }
    }
}
