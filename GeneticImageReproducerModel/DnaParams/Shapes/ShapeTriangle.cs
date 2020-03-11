using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    class ShapeTriangle:Shape
    {
        public Point P1;
        public Point P2;
        public Point P3;
        public ShapeTriangle()
        {
            (P1.X, P1.Y) = (-1, -1);
            (P2.X, P2.Y) = (1, -1);
            (P3.X, P3.Y) = (0, 1);
        }
        
        //todo: should add some constraints via arguments 
        new public void SetRandomParams(Random rand)
        {
            (P1.X, P1.Y) = (rand.Next(0, 512), rand.Next(0, 512));
            (P2.X, P2.Y) = (rand.Next(0, 512), rand.Next(0, 512));
            (P3.X, P3.Y) = (rand.Next(0, 512), rand.Next(0, 512));
        }
        
    }
}
