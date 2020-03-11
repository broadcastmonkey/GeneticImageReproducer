using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    public class ShapeCircle:Shape
    {
        public Int32 R;
        public Point Center;

        //todo: should add some constraints via arguments 
        new public void SetRandomParams(Random rand)
        {
            R = rand.Next(1, 400);
            Center.X = rand.Next(0, 512);
            Center.Y = rand.Next(0, 512);
        }
    }
}
