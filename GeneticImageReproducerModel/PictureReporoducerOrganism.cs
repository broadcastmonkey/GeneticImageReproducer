using GeneticImageReproducerModel.BaseClasses;
using GeneticImageReproducerModel.DnaParams;
using GeneticImageReproducerModel.DnaParams.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel
{
    public class PictureReporoducerOrganism:Organism
    {
        Shape Shape;
        Color Color;

       
        public PictureReporoducerOrganism(ShapeType type)
        {
            Shape = type switch
            {
                ShapeType.Circle => new ShapeCircle(),
                ShapeType.Triangle => new ShapeTriangle(),
                ShapeType.Rectangle => new ShapeRectnagle(),
                _ => null
            };

            
        }
        public void SetRandomParams(Random rand)
        {
            Shape.SetRandomParams(rand);
            Color.SetRandomParams(rand);
        }
        new public void CalculateFitness(ExpectedResult expectedResult)
        {

        }
    }
}
