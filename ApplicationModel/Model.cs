using Manager;
using NeuralNetworkRealization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Activator = Manager.Activator;

namespace ApplicationModel
{
    public class Model
    {
        private double timeElapsed;
        public NeuralNetwork NeuralNetwork { get; set; }
        public bool IsLearned { get; private set; } = false;
        public bool IsNeuralNetworkExists
        {
            get
            {
                return NeuralNetwork != null;
            }
        }

        public long IterationsAmount
        {
            get
            {
                return NeuralNetwork.amount;
            }
        }
        public double MillisecondsElapsed
        {
            get
            {
                return timeElapsed;
            }
        }

        public int Inputs
        {
            get
            {
                return NeuralNetwork.Inputs;
            }
        }
        public int Outputs
        {
            get
            {
                return NeuralNetwork.Outputs;
            }
        }


        public Dictionary<long, double> Statistic { get; private set; }

        public Model()
        {
        }

        public void CreateNeuralNetwork(Manager.Activator activator, int inputsAmount, int[] layersDescriptor)
        {
            NeuralNetwork = new NeuralNetwork(inputsAmount, layersDescriptor, activator);
        }

        public void TrainNeuralNetwork(List<double[]> trainInputs, List<double[]> trainOutputs, double eps, int populationAmount, int maxIterations, double mutationPropability)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            NeuralNetwork.Train(trainInputs, trainOutputs, eps, populationAmount, maxIterations, mutationPropability);
            stopwatch.Stop();
            timeElapsed = stopwatch.Elapsed.TotalMilliseconds;
            Statistic = NeuralNetwork.Statistic;
            IsLearned = true;
        }

        public void ReadFromFileNeuralNetwork(string path)
        {
            string descriptor = File.ReadAllText(path);
            NeuralNetwork = NeuralNetwork.CreateNeuralNetwork(descriptor);
        }

        public void LoadNeuralNetworkFromFile(string path)
        {
            string description = File.ReadAllText(path);
            NeuralNetwork = NeuralNetwork.CreateNeuralNetwork(description);
            IsLearned = true;
        }

        public void SaveNeuralNetwork(string path)
        {
            NeuralNetwork.SaveToFile(path);
        }

        public List<double[]> LoadTrainData(string path, out int inputs, out int outputs)
        {
            string[] data = File.ReadAllText(path).Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] columnsInfo = data[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ConvertSequenseToInt().ToArray();
            inputs = columnsInfo[0];
            outputs = columnsInfo[1];

            List<double[]> result = new List<double[]>();
            for(int i = 1; i < data.Length; i++)
            {
                result.Add(data[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ConvertSequenseToDouble().ToArray());
            }

            return result;
        }

        public void SaveTrainData(string path, string data)
        {
            File.WriteAllText(path, data);
        }
    }
}
