using GeneticImageReproducerModel.BaseClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    public enum ShapeType { Circle,Rectangle, Triangle, None }
    public class Shape:MutableDnaParam
    {
        public ShapeType Type = ShapeType.None;
        public ShapeColor Color;

        public Shape()
        {
            Color = new ShapeColor();
        }
        public Shape(Shape shape)
        {
            Color.Color = System.Drawing.Color.FromArgb(shape.Color.Color.A, shape.Color.Color.R, shape.Color.Color.G, shape.Color.Color.B);
        }
        public virtual void Draw(Graphics g)
        {
            
        }
    }

  
}
