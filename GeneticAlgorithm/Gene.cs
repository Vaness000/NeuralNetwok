using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmRealization
{
    public class Gene
    {
        public double[] Allels { get; set; }
        private double fitness;
        public double Fitness
        {
            get
            {
                return fitness;
            }
        }
        

        public Gene(params double[] allels)
        {
            Array.Copy(allels, Allels = new double[allels.Length], allels.Length);
        }

        //public void CalculateFitness(double[] currentSolution, double[] solution)
        //{
        //    int index = 1;
        //    double current = currentSolution.Aggregate((sum, item) => sum + item * Math.Pow(2, index++));
        //    index = 1;
        //    double etalon = solution.Aggregate((sum, item) => sum + item * Math.Pow(2, index++));
        //    fitness = Math.Abs(current - etalon);
        //}

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
