using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.BaseClasses
{
    public class Organism : IGeneticAlgorithmOrganism
    {
        public double Fitness;
        protected List<MutableDnaParam> Dna;
        public Organism ()
        {
            Dna = new List<MutableDnaParam>();
        }
        public virtual void CalculateFitness(ExpectedResult expectedResult)
        {
            

        }
        public virtual void CalculateResult()
        {

        }
        /*public IGeneticAlgorithmOrganism CreateOffSpring(IGeneticAlgorithmOrganism partner)
        {
            return this;
        }*/
    }
}
