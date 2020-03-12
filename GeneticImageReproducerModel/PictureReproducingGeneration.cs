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

        public PictureReproducingGeneration(int count, int shapesCount, int width, int height, Random rand)
        {
            Population = new List<PictureReproducerOrganism>();
            for(int i=0;i<count;i++)
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


    }
}
