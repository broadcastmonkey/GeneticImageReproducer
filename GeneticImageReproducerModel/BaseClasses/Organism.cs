using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.BaseClasses
{
    public class Organism : IGeneticAlgorithmOrganism
    {
        private double Fitness;
        protected List<MutableDnaParam> Dna;
        public Organism ()
        {
            Dna = new List<MutableDnaParam>();
        }
        public void CalculateFitness(ExpectedResult expectedResult)
        {
            

        }
        public IGeneticAlgorithmOrganism CreateOffSpring(IGeneticAlgorithmOrganism partner)
        {
            return this;
        }
    }
}
