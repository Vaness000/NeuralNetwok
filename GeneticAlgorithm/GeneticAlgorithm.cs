using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmRealization
{
    public class GeneticAlgorithm
    {
        private List<double> fitneses;
        private List<Chromosome> tournamentWinners;
        private int geneLength;
        private int populationAmount;
        private double eps;
        private bool hasSolution = false;
        private long iterations = 0;
        private long maxIterations = 0;
        private double mutationPropability;
        private Random random = new Random();

        public Dictionary<long, double> Statistic { get; private set; } = new Dictionary<long, double>();
        public double[] Solution { get; private set; }
        public List<Chromosome> Population { get; private set; }
        public bool HasSolution
        {
            get
            {
                return hasSolution;
            }
        }

        public GeneticAlgorithm(int amountAllels, int populationAmount, double eps, long maxIterations, double mutationPropability)
        {
            fitneses = new List<double>();
            geneLength = amountAllels;
            this.populationAmount = populationAmount;
            GenerateInitialPopulation(populationAmount);
            this.eps = eps;
            this.maxIterations = maxIterations;
            this.mutationPropability = mutationPropability;
        }

        public void GenerateInitialPopulation(int populationAmount)
        {
            Population = new List<Chromosome>(populationAmount);
            for(int i = 0; i < populationAmount; i++)
            {
                double[] allels = new double[geneLength];
                for(int j = 0; j < geneLength; j++)
                {
                    allels[j] = -1 + random.NextDouble() * 2;
                }

                Population.Add(new Chromosome(allels));
            }
        }

        public void MakeGeneration()
        {
            double avg = Population.Average(x => x.Fitness);
            fitneses.Add(avg);
            if(iterations % 50 == 0)
            {
                Statistic.Add(iterations, avg);
            }
            
            iterations++;
            CheckSolutions();
            if (hasSolution)
            {
                return;
            }
            Tournament();
            Crossing();
            Mutation();
            
        }

        private void CheckSolutions()
        {
            List<Chromosome> solutions = new List<Chromosome>();
            foreach(var cromosome in Population)
            {
                if(cromosome.Fitness < eps)
                {
                    solutions.Add(cromosome);
                }
            }

            if (solutions.Count > 0)
            {
                Solution = solutions.OrderBy(x => x.Fitness).First().Genes;
                hasSolution = true;
            }

            if(iterations == maxIterations)
            {
                Solution = Population.OrderBy(x => x.Fitness).First().Genes;
                hasSolution = true;
            }
        }

        private void Tournament()
        {
            tournamentWinners = new List<Chromosome>();
            while(tournamentWinners.Count != populationAmount)
            {
                Chromosome cromosome = GetWinner();
                tournamentWinners.Add(cromosome);
            }
        }

        private Chromosome GetWinner()
        {
            List<Chromosome> genes = new List<Chromosome>();
            for(int i = 0; i < 2; i++)
            {
                int element = random.Next(0, populationAmount);
                genes.Add(Population[element]);
            }

            double bestFitness = genes.Min(x => x.Fitness);
            return genes.Find(x => x.Fitness == bestFitness);
        }

        private void Crossing()
        {
            List<Chromosome> firstParents = new List<Chromosome>();
            List<Chromosome> secondParents = new List<Chromosome>();

            for(int i = 0; i < populationAmount; i++)
            {
                if(i % 2 == 0)
                {
                    firstParents.Add(tournamentWinners[i]);
                }
                else
                {
                    secondParents.Add(tournamentWinners[i]);
                }
            }

            int crossingAmount = firstParents.Count == secondParents.Count ? secondParents.Count : Math.Min(firstParents.Count, secondParents.Count);
            Population.Clear();
            for(int i = 0; i < crossingAmount; i++)
            {
                int crossingPoint = random.Next(1, geneLength - 1);
                double[] firstChildrenAllels = SwipeAllels(firstParents[i], secondParents[i], out double[] secondChildrenAllels);
                Population.Add(new Chromosome(firstChildrenAllels));
                Population.Add(new Chromosome(secondChildrenAllels));
            }

            if(Population.Count != populationAmount)
            {
                int index = random.Next(0, tournamentWinners.Count);
                Population.Add(tournamentWinners[index]);
            }
        }
        private double[] SwipeAllels(Chromosome firsParent, Chromosome secondParent, out double[] secondChildrenAllels)
        {
            double[] firstChildrenAllels = new double[geneLength];
            secondChildrenAllels = new double[geneLength];
            int isFirst = random.Next(0, 1);

            for (int i = 0; i < geneLength; i++)
            {
                if (isFirst == 0)
                {
                    firstChildrenAllels[i] = firsParent.Genes[i];
                    secondChildrenAllels[i] = secondParent.Genes[i];
                }
                else
                {
                    firstChildrenAllels[i] = secondParent.Genes[i];
                    secondChildrenAllels[i] = firsParent.Genes[i];
                }
            }

            return firstChildrenAllels;
        }

        private void Mutation()
        {
            foreach(Chromosome cromosome in Population)
            {
                if(random.NextDouble() < mutationPropability)
                {
                    int mutationPosition = random.Next(0, geneLength);
                    cromosome.Genes[mutationPosition] += (-0.3 + random.NextDouble() * 0.6);
                }
            }
        }
    }
}
