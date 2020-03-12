using GeneticImageReproducerModel.BaseClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams
{
    public class ShapeColor:MutableDnaParam
    {
        public Color Color;



        new public void SetRandomParams(Random rand)
        {
            Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
          
        }


    }
}
