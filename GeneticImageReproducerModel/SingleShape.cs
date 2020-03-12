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
    public class SingleShape:MutableDnaParam
    {
        public Shape Shape;
        

        public SingleShape(SingleShape shape)
        {
            if(shape.Shape is ShapeTriangle triangle)
            {
                Shape = new ShapeTriangle(triangle); 
            }

        }
        public SingleShape(Random rand)
        {
           
            Array values = Enum.GetValues(typeof(ShapeType));

            ShapeType randomShape = (ShapeType)values.GetValue(rand.Next(values.Length-1));

            InitShape(ShapeType.Triangle);
        }

        private void InitShape(ShapeType type)
        {
            Shape = type switch
            {
                ShapeType.Circle => new ShapeCircle(),
                ShapeType.Triangle => new ShapeTriangle(),
                ShapeType.Rectangle => new ShapeRectangle(),
                _ => null
            };
           

        }
        public SingleShape(ShapeType type)
        {
            InitShape(type); 
        }

        override public void SetRandomParams(Random rand)
        {
            Shape.SetRandomParams(rand);
            
        }

     
    }
}
