using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    public class ShapeCircle:Shape
    {
        public Int32 R;
        public Point Center;
        public ShapeCircle(ShapeCircle circle) : base(circle)
        {
            Type = ShapeType.Circle;
            R = circle.R;
            (Center.X, Center.Y) = (circle.Center.X, circle.Center.Y);
        }
        public ShapeCircle() : base()
        {
            Type = ShapeType.Circle;
        }
        //todo: should add some constraints via arguments 
        override public void SetRandomParams(Random rand)
        {
            
            R = rand.Next(1, 400);
            Center.X = rand.Next(0, 512);
            Center.Y = rand.Next(0, 512);
            Color.SetRandomParams(rand);
        }
        override public void Draw(Graphics g)
        {
            
            
            SolidBrush sb = new SolidBrush(Color.Color);
            g.FillEllipse(sb, Center.X, Center.Y,R, R); 
        }
    }
}
