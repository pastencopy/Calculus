using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        // Simple Differential Equation 1
        // y' = 2x
        private List<double> example1(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add( 2.0 * y[0] );

            return result;
        }

        // Simple Differential Equation 2
        // y' = 2
        private List<double> example2(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(2.0);

            return result;
        }

        // Simple Differential Equation 3
        // y' = cos(x)
        private List<double> example3(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(Math.Cos(t));
            return result;
        }

        // Simple Differential Equation 4
        // y' = -y
        private List<double> example4(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(0); // y''은 측정불가
            result.Add(-y[1]);
            return result;
        }

        // Simple Differential Equation 5
        // y' = 1/y
        private List<double> example5(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(0); // y''은 측정불가
            result.Add(1/y[1]);
            return result;
        }

        // Simple Differential Equation 6
        // y' = cos(x) + sin(x)
        private List<double> example6(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(Math.Cos(t) + Math.Sin(t));
            return result;
        }

        // Simple Differential Equation 7
        // y' = e + sin(x)
        private List<double> example7(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(Math.E + Math.Sin(t));
            return result;
        }

        // predator–prey equations
        // https://en.wikipedia.org/wiki/Lotka%E2%80%93Volterra_equations
        private List<double> predatorprey(double t, List<double> y)
        {
            List<double> result = new List<double>();

            double a = 2.5; //alpha
            double b = 1.0; //beta
            double d = 0.5; //delta
            double c = 3.0; //gamma

            /*
             * Prey:
             *      dx/dt = alpha*x - beta*xy
             * 
             * Predators:
             *      dy/dt =  delta*xy - gamma*y
             * 
             * */

            result.Add( a * y[0]        -  b * y[0] * y[1] ); //Prey
            result.Add( d * y[0] * y[1] -  c * y[1]        ); //Predators

            return result;
        }
        
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnCalcPredatorPrey_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();            
            input_values.Add(6.0);
            input_values.Add(20.0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, predatorprey, 0, 15, 30000);
            DifferentialSolver.DrawGraph2D( Graphics.FromImage(drawImage),picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example1, 0, 3, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential2_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example2, 0, 2, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential3_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example3, 0, 10, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential4_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example4, 0, 10, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential5_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example5, -100, 100, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 100);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential6_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example6, 0, 30, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential7_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, example7, 0, 30, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, 0);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }
    }
}
