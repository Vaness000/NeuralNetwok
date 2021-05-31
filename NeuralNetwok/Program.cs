using Manager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Activator = Manager.Activator;

namespace NeuralNetworkRealization
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputLayer = new double[] { 1, 1 };
            List<double[]> trainingInputs = new List<double[]>()
            {
                new double[] {0, 0, 0, 0},//1
                new double[] {0, 0, 0, 1},//2
                new double[] {0, 0, 1, 0},//3
                new double[] {0, 0, 1, 1},//4
                new double[] {0, 1, 0, 0},//5
                new double[] {0, 1, 0, 1},//6
                new double[] {1, 0, 0, 0},//7
                new double[] {1, 0, 0, 1},//8
                new double[] {1, 0, 1, 0},//9
                new double[] {1, 0, 1, 1},//10
                new double[] {1, 1, 0, 0},//11
                new double[] {1, 1, 1, 1},//12
                //new double[] {1, 1, 0, 1},//13
                //new double[] { 0, 1, 1, 1 }//14
            };
            List<double[]> trainingOutputs = new List<double[]>()
            {
                new double[] {1},//1
                new double[] {1},//2
                new double[] {0},//3
                new double[] {0},//4
                new double[] {0},//5
                new double[] {0},//6
                new double[] {1},//7
                new double[] {1},//8
                new double[] {0},//9
                new double[] {0},//10
                new double[] {0},//11
                new double[] {0},//12
                //new double[] {0},//13
            };

            Activator activator = ActivatorsList.GetActivators().First(x => x.TitleFunc == "Сигмоид");
            NeuralNetwork nw = new NeuralNetwork(4, new int[] { 8, 1 }, activator);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            nw.Train(trainingInputs, trainingOutputs, 0.01, 20, 5000, 0.015);
            watch.Stop();

            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            Console.WriteLine(nw.amount);
            nw.Traverse(new double[] { 1, 1, 1, 0 });
            Console.WriteLine(nw.Solution[0]);
            Console.WriteLine();
            nw.SaveToFile("network.txt");

            NeuralNetwork network = ReadFromFile("network.txt");
            network.Traverse(new double[] { 1, 1, 1, 0 });
            Console.WriteLine(network.Solution[0]);
            Console.ReadKey();
        }

        static double F(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static NeuralNetwork ReadFromFile(string path)
        {
            string description = File.ReadAllText(path);
            return NeuralNetwork.CreateNeuralNetwork(description);
        }
    }
}
