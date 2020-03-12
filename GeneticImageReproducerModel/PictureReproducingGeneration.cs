using GeneticImageReproducerModel.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel
{
    public class PictureReproducingGeneration
    {
        public List<PictureReproducerOrganism> Population;
        int PopulationCount = 0;
        Random randGen;
        public PictureReproducingGeneration(int populationCount, int shapesCount, int width, int height, Random rand)
        {
            randGen = rand;
            Population = new List<PictureReproducerOrganism>();
            PopulationCount = populationCount;
            for(int i=0;i<populationCount;i++)
            {
                Population.Add(new PictureReproducerOrganism(shapesCount,width,height,rand));
            }
            foreach(var o in Population)
            { o.SetRandomParams(rand); }
        }
        public void CalculateFitness(BitmapResult result)
        {
            foreach (var o in Population)
            {
                o.CalculateFitness(result);
            }
            Population = Population.OrderByDescending(x => x.Fitness).ToList();
        }
        public void CalculateResults()
        {
            foreach (var o in Population)
            {
                o.CalculateResult();
            }
        }
        private PictureReproducerOrganism SelectRandom()
        {
            return Population[randGen.Next(0, Population.Count - 1)];
        }
        public void NaturalSelection(Int32 survivorsCount)
        {
            // only best-fit organism stay alive
            Population.RemoveRange(100,Population.Count-100);

            while(Population.Count<PopulationCount)
            {
                var parrent1 = SelectRandom();
                var parrent2 = SelectRandom(); // naive random selection -> todo: should retrieve val based on fitness value

                Population.Add(parrent1.CreateOffSpring(parrent2));
            }
            


        }



    }
}
