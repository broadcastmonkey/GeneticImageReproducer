using GeneticImageReproducerModel.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.DnaParams
{
    public class Color:MutableDnaParam
    {
        public double R;
        public double G;
        public double B;
        public double A;

        public Color()
        {
            R = G = B = 0;
            A = 1;
        }

        new public void SetRandomParams(Random rand)
        {
            R = rand.NextDouble();
            G = rand.NextDouble();
            B = rand.NextDouble();
            A = rand.NextDouble();
        }


    }
}
