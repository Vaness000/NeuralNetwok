using Manager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmRealization
{
    public class GeneticAlgorithm
    {
        private List<double> fitneses;
        private List<Gene> tournamentWinners;
        private int amountAllelsInGene;
        private int populationAmount;
        private double eps;
        private bool hasSolution = false;
        private long iterations = 0;
        private long maxIterations = 0;
        private double mutationPropability;
        private Random random = new Random(2281337);

        public Dictionary<long, double> Statistic { get; private set; } = new Dictionary<long, double>();
        public double[] Solution { get; private set; }
        public List<Gene> Population { get; private set; }
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
            amountAllelsInGene = amountAllels;
            this.populationAmount = populationAmount;
            GenerateInitialPopulation(populationAmount);
            this.eps = eps;
            this.maxIterations = maxIterations;
            this.mutationPropability = mutationPropability;
        }

        public void GenerateInitialPopulation(int populationAmount)
        {
            //Random rnd = new Random();
            Population = new List<Gene>(populationAmount);
            for(int i = 0; i < populationAmount; i++)
            {
                double[] allels = new double[amountAllelsInGene];
                for(int j = 0; j < amountAllelsInGene; j++)
                {
                    allels[j] = -1 + random.NextDouble() * 2;
                }

                Population.Add(new Gene(allels));
            }
        }

        public void MakeGeneration()
        {
            
            if(iterations % 50 == 0)
            {
                Statistic.Add(iterations, Population.Average(x => x.Fitness));
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
            List<Gene> solutions = new List<Gene>();
            foreach(var gene in Population)
            {
                if(gene.Fitness < eps)
                {
                    solutions.Add(gene);
                }
            }

            if (solutions.Count > 0)
            {
                Solution = solutions.OrderBy(x => x.Fitness).First().Allels;
                hasSolution = true;
            }

            if(!hasSolution && iterations == maxIterations)
            {
                hasSolution = true;
                Solution = Population.OrderBy(x => x.Fitness).First().Allels;
            }
        }

        private void Tournament()
        {
            tournamentWinners = new List<Gene>();
            while(tournamentWinners.Count != populationAmount)
            {
                Gene gene = GetWinner();
                tournamentWinners.Add(gene);
            }
        }

        private Gene GetWinner()//разбить на подгруппы нормально
        {
            List<Gene> genes = new List<Gene>();
            for(int i = 0; i < 3; i++)
            {
                int element = random.Next(0, populationAmount);
                genes.Add(Population[element]);
            }

            double bestFitness = genes.Min(x => x.Fitness);
            return genes.Find(x => x.Fitness == bestFitness);
        }

        private void Crossing()
        {
            List<Gene> firstParents = new List<Gene>();
            List<Gene> secondParents = new List<Gene>();

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
                int crossingPoint = random.Next(0, amountAllelsInGene);
                double[] firstChildrenAllels = SwipeAllels(firstParents[i], secondParents[i], crossingPoint, out double[] secondChildrenAllels);
                Population.Add(new Gene(firstChildrenAllels));
                Population.Add(new Gene(secondChildrenAllels));
            }

            if(Population.Count != populationAmount)
            {
                int index = random.Next(0, tournamentWinners.Count);
                Population.Add(tournamentWinners[index]);
            }
        }

        private double[] SwipeAllels(Gene firsParent, Gene secondParent, int crossingPoint, out double[] secondChildrenAllels)
        {
            double[] firstChildrenAllels = new double[amountAllelsInGene];
            secondChildrenAllels = new double[amountAllelsInGene];

            for(int i = 0; i < amountAllelsInGene; i++)
            {
                if(i < crossingPoint)
                {
                    firstChildrenAllels[i] = firsParent.Allels[i];
                    secondChildrenAllels[i] = secondParent.Allels[i];
                }
                else
                {
                    firstChildrenAllels[i] = secondParent.Allels[i];
                    secondChildrenAllels[i] = firsParent.Allels[i];
                }
            }

            return firstChildrenAllels;
        }

        private void Mutation()
        {
            foreach(Gene gene in Population)
            {
                if(random.NextDouble() < mutationPropability)
                {
                    int mutationPosition = random.Next(0, amountAllelsInGene);
                    gene.Allels[mutationPosition] += (-0.3 + random.NextDouble() * 0.6);
                }
            }
        }
    }
}
