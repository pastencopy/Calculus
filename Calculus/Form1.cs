using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculus
{
    public partial class Form1 : Form
    {
        Bitmap drawImage;
        public Form1()
        {
            InitializeComponent();

            drawImage = new Bitmap(picCanvas.Width, picCanvas.Height);

        }

        private List<double> example1(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add( 2.0 * y[0] );

            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example1, 0, 3, 10000);

            //Draw Graph
            DrawGraph2D(output);
        }

        private void DrawGraph2D(List<List<double>> output)
        {
            Graphics g = Graphics.FromImage(drawImage);

            g.Clear(Color.White);
            g.TranslateTransform(picCanvas.Width / 2, picCanvas.Height / 2);
            g.DrawLine(Pens.Black, (picCanvas.Width / 2), 0, -(picCanvas.Width / 2), 0);
            g.DrawLine(Pens.Black, 0, - (picCanvas.Height / 2), 0, picCanvas.Height / 2);

            g.DrawLine(Pens.Red, 0, 0, -100, -200);

            double max = 0.0;
            output.ForEach(
                (item) => { 
                    if (max <= item[0])
                    {
                        max = item[0];
                    }
                });

            double graph_x_size = ((picCanvas.Width / 2.0) / output.Count);
            double graph_y_length = ((picCanvas.Height / 2.0));

            for (int i = 0; i < output.Count; i++)
            {
                List<double> item = output[i];
                double y = item[0];
                int posX = (int)(graph_x_size * i);
                int posY = - (int)(graph_y_length * (y/ max)); //좌표계가 반대방향
                g.FillEllipse(Brushes.Blue, posX, posY, 3, 3);
            }

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }
    }
}
