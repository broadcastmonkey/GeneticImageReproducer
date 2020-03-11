using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.BaseClasses
{
    public interface IGeneticAlgorithmOrganism
    {
        void CalculateFitness(ExpectedResult expectedResult);
        IGeneticAlgorithmOrganism CreateOffSpring(IGeneticAlgorithmOrganism partner);
    }
}
