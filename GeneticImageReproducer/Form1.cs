using GeneticImageReproducerModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticImageReproducer
{
    public partial class Form1 : Form
    {
        Bitmap SourceImage;
        PictureReproducingGeneration Generation;

        Thread GeneticAlgorithm;
        public Form1()
        {
            InitializeComponent();
            SourceImage = new Bitmap("c:/devel/test.jpg");

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty| BindingFlags.Instance | BindingFlags.NonPublic, null, panelImage, new object[] { true });

            Generation = new PictureReproducingGeneration(200, 100, 512, 512, new Random());

            GeneticAlgorithm = new Thread(new ThreadStart(PerformGeneticAlgorithm));
        }

        private void btnCreateTestImage_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            PictureReproducerOrganism samplePicture = new PictureReproducerOrganism(50,512,512,rand);
            
            samplePicture.CalculateResult();
            Graphics g = panelImage.CreateGraphics();

         
        }

        void PerformGeneticAlgorithm()
        {
            
            BitmapResult expectedResult = new BitmapResult(SourceImage);
            int generationsCount = 200;
            for (int i = 1; i < generationsCount; i++)
            {
                Generation.CalculateResults();
                Generation.CalculateFitness(expectedResult);
                Generation.NaturalSelection(100);
                

                this.Invoke(new MethodInvoker(delegate ()
                {
                    int perc = i * 100 / generationsCount;
                    txtLog.Text = "GEN " + i + " (" + perc + "%)\r\n";
                    foreach (var o in Generation.Population)
                    {
                        txtLog.Text += o.Fitness + "\r\n";
                    }
                    DrawCurrentBest(Generation.Population[0]);
                    Generation.Population[0].GetResult().Save("c:/devel/gen/" + i.ToString("d5") + ".jpg");
                }));

            }
            GeneticAlgorithm.Abort();
        }
        private void btnRunSimulation_Click(object sender, EventArgs e)
        {
            DrawSourceImage();
            GeneticAlgorithm.Start();
            

        }
        void DrawCurrentBest(PictureReproducerOrganism organism)
        {
            Graphics g = panelImage.CreateGraphics();
            g.FillRectangle(new SolidBrush(System.Drawing.Color.Black), 0, 0, panelImage.Width, panelImage.Height);
            g.DrawImage(organism.GetResult(), new Point(0, 0));
            

        }

        void DrawSourceImage()
        {
            Graphics g = panel1.CreateGraphics();

            g.FillRectangle(new SolidBrush(System.Drawing.Color.Black), 0, 0, SourceImage.Width, SourceImage.Height);
            g.DrawImage(SourceImage, new Point(0, 0));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalculateFitness_Click(object sender, EventArgs e)
        {
            DrawSourceImage();
            BitmapResult expectedResult = new BitmapResult(SourceImage);
            Generation.CalculateResults();
            Generation.CalculateFitness(expectedResult);

            foreach (var o in Generation.Population)
            {
                txtLog.Text += o.Fitness + "\r\n";
            }
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            DrawCurrentBest(Generation.Population[2]);
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            DrawCurrentBest(Generation.Population[1]);
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            DrawCurrentBest(Generation.Population[0]);
        }
    }
}
