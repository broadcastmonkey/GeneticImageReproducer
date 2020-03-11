using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    public class ShapeRectnagle:Shape
    {
        public Point CenterPosition;
        public Int32 Width;
        public Int32 Height;
        public ShapeRectnagle()
        {
            (Width, Height)= (0,0);
            (CenterPosition.X, CenterPosition.Y) = (0, 0);
        }

        //todo: should add some constraints via arguments 
        new public void SetRandomParams(Random rand)
        {
            Width = rand.Next(1, 400);
            Height = rand.Next(1, 400);
            CenterPosition.X = rand.Next(0, 512);
            CenterPosition.Y = rand.Next(0, 512);
        }
    }
}
