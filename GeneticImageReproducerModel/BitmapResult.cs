using GeneticImageReproducerModel.BaseClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel
{
    public class BitmapResult:ExpectedResult
    {
        public Bitmap Image;
        public BitmapResult(Bitmap img)
        {
            Image = img;
        }
    }
}
