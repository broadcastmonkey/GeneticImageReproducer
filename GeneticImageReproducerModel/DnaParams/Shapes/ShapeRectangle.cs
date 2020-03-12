using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    public class ShapeRectangle:Shape
    {
        public Point CenterPosition;
        public float Width;
        public float Height;

        public ShapeRectangle(ShapeRectangle rectangle):base(rectangle)
        {
            Type = ShapeType.Rectangle;
            (Width, Height) = (rectangle.Width, rectangle.Height);
            (CenterPosition.X, CenterPosition.Y) = (rectangle.CenterPosition.X, rectangle.CenterPosition.Y);
        }
        public ShapeRectangle():base()
        {
            Type = ShapeType.Rectangle;
            (Width, Height)= (0,0);
            (CenterPosition.X, CenterPosition.Y) = (0, 0);
        }

        //todo: should add some constraints via arguments 
        override public void SetRandomParams(Random rand)
        {
            Width = rand.Next(1, 400);
            Height = rand.Next(1, 400);
            CenterPosition.X = rand.Next(0, 512);
            CenterPosition.Y = rand.Next(0, 512);
            Color.SetRandomParams(rand);
        }
        override public void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Color);
            g.FillRectangle(sb, CenterPosition.X, CenterPosition.Y, Width , Height);
        }
    }
}
