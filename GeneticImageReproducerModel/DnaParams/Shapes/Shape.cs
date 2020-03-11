using GeneticImageReproducerModel.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams.Shapes
{
    public enum ShapeType { Circle,Rectangle, Triangle }
    public class Shape:MutableDnaParam
    {
        public ShapeType Type = ShapeType.Circle;
    }


}
