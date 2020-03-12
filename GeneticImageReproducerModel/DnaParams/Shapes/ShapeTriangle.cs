using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Point[] Points;

        private void RestorePointsPointers()
        {
            Points = new Point[3];
            Points[0] = P1;
            Points[1] = P2;
            Points[2] = P3;
        }
        public ShapeTriangle(ShapeTriangle triangle):base(triangle)
        {
            Type = ShapeType.Triangle;
            (P1.X, P1.Y) = (triangle.P1.X,triangle.P1.Y);
            (P2.X, P2.Y) = (triangle.P3.X,triangle.P2.Y);
            (P3.X, P3.Y) = (triangle.P3.X, triangle.P3.Y);
            RestorePointsPointers();
        }
        public ShapeTriangle():base()
        {
            Type = ShapeType.Triangle;
            (P1.X, P1.Y) = (-100, -100);
            (P2.X, P2.Y) = (100, -100);
            (P3.X, P3.Y) = (0, 100);
            RestorePointsPointers();
          
        }

        //todo: should add some constraints via arguments 
        override public void SetRandomParams(Random rand)
        {
             (P1.X, P1.Y) = (rand.Next(0, 512), rand.Next(0, 512));
            (P2.X, P2.Y) = (rand.Next(0, 512), rand.Next(0, 512));
            (P3.X, P3.Y) = (rand.Next(0, 512), rand.Next(0, 512));
            RestorePointsPointers();
            Color.SetRandomParams(rand);
        }
        override public void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Color);
            g.FillPolygon(sb, Points);
        }
       
        public override void Mutate(Random rand,double probability)
        {
            double chances = rand.NextDouble();
            if(chances<probability)
            {
                P1.X += rand.Next(-50, 50);
                P1.Y += rand.Next(-50, 50);
                P2.X += rand.Next(-50, 50);
                P2.Y += rand.Next(-50, 50);
                P3.X += rand.Next(-50, 50);
                P3.Y += rand.Next(-50, 50);
                RestorePointsPointers(); //todo: should not be doing it like that -> see why pointers are sometimes pointing to prev values
            }
        }
    }
}
