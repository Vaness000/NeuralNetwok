using System;

namespace GeneticAlgorithmRealization
{
    public class Chromosome
    {
        public double[] Genes { get; set; }
        private double fitness;
        public double Fitness
        {
            get
            {
                return fitness;
            }
        }

        public Chromosome(params double[] allels)
        {
            Array.Copy(allels, Genes = new double[allels.Length], allels.Length);
        }

        public void CalculateFitness(double[] currentSolution, double[] solution)// 1/2 * sum( (d-y)^2 )
        {
            double errorsSum = 0;
            for(int i = 0; i < currentSolution.Length; i++)
            {
                errorsSum += Math.Pow(solution[i] - currentSolution[i], 2);
            }

            fitness = errorsSum / 2;
        }
    }
}
