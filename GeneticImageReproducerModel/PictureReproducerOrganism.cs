using GeneticImageReproducerModel.BaseClasses;
using GeneticImageReproducerModel.DnaParams;
using GeneticImageReproducerModel.DnaParams.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel
{
    public class PictureReproducerOrganism:Organism
    {
        List<SingleShape> Shapes;

        Graphics Result;
        Bitmap ResultBitmap;
        Int32 Width;
        Int32 Height;
        public PictureReproducerOrganism(PictureReproducerOrganism parrent)
        {
            Shapes = new List<SingleShape>();
            Width = parrent.Width;
            Height = parrent.Height;

            ResultBitmap = new Bitmap(Width, Height);
            ResultBitmap.MakeTransparent(System.Drawing.Color.Transparent);

        }
        public PictureReproducerOrganism(Int32 shapesCount, Int32 width, Int32 height, Random rand)
        {
            Shapes = new List<SingleShape>();
            

            for(int i=0;i<shapesCount;i++)
            {
                Shapes.Add(new SingleShape(rand));
            }

            ResultBitmap = new Bitmap(width, height);
            ResultBitmap.MakeTransparent(System.Drawing.Color.Transparent);

            Height = height;
            Width = width;
        }

        public Bitmap GetResult()
        {
            return ResultBitmap;
        }
        public void SetRandomParams(Random rand)
        {
            foreach (var s in Shapes)
                s.SetRandomParams(rand);
        }


        override public void CalculateFitness(ExpectedResult expectedResult)
        {
            double difference = 0;
            double total = 0;
            if(expectedResult is BitmapResult)
            {
                var sourceImage = (BitmapResult)expectedResult; //todo: correct code so it uses c# 8.0 mechanisms
                //todo: check if images sizes are same

                Int32 step = 10;
                for (int y = 0; y < Height; y+=step)
                {
                    for (int x = 0; x < Width; x+=step)
                    {
                        var p1 = ResultBitmap.GetPixel(x, y);
                        var p2 = sourceImage.Image.GetPixel(x, y);
                        total += 3*255;
                        //p2 = p1;
                        difference += Math.Abs(p1.R - p2.R) + Math.Abs(p1.G - p2.G) + Math.Abs(p1.B - p2.B);
                    }
                }
                // assuming images is 512x512
                Fitness = (total - difference) / total;
            }
        }
        override public void CalculateResult()
        {
            Result = Graphics.FromImage(ResultBitmap);
         //   Result.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

            Result.FillRectangle(new SolidBrush(System.Drawing.Color.Black),0,0,ResultBitmap.Width,ResultBitmap.Height);
            foreach (var s in Shapes)
            {
                s.Shape.Draw(Result);
            }
        }

        public PictureReproducerOrganism CreateOffSpring(PictureReproducerOrganism partner)
        {
            PictureReproducerOrganism child = new PictureReproducerOrganism(this);

            //todo: check for constraints etc
            
            for(int i=0;i<this.Shapes.Count/2;i++)
            {
                child.Shapes.Add(new SingleShape(this.Shapes[i]));
            }

            return child;
        }
    }
}
