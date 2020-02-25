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
        
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnCalcPredatorPrey_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();            
            input_values.Add(6.0);
            input_values.Add(20.0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.predatorprey, 0, 15, 30000);
            DifferentialSolver.GraphType graphType = DifferentialSolver.GraphType.NORMAL;
            if (chkUseXYLine.Checked == true)
            {
                graphType = DifferentialSolver.GraphType.CONNECT_XY;
            }
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, graphType);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential_Click(object sender, EventArgs e)
        {

            

            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example1, 0, 4, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential2_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example2, 0, 2, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential3_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example3, 0, 10, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential4_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example4, 0, 10, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential5_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example5, 1, 5, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential6_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example6, 0, 30, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential7_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example7, 0, 30, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential8_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0); //u
            input_values.Add(1); //v

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example8, 0, 5, 10000);

            DifferentialSolver.GraphType graphType = DifferentialSolver.GraphType.NORMAL;
            if (chkUseXYLine.Checked == true)
            {
                graphType = DifferentialSolver.GraphType.CONNECT_XY;
            }
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, graphType);//Draw Graph

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential9_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example9, -20, 20, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential10_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example10, -20, 20, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential11_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example11, 1, 5, 10000);
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential12_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(0);  // y(0)
            input_values.Add(-2); // dydt(0)

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example12, 0, 20, 10000);

            DifferentialSolver.GraphType graphType = DifferentialSolver.GraphType.NORMAL;
            if (chkUseXYLine.Checked == true)
            {
                graphType = DifferentialSolver.GraphType.CONNECT_XY;
            }
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, graphType);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnSimpleDifferential13_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1.0);
            input_values.Add(1.0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.example13, 0, 30, 30000);
            DifferentialSolver.GraphType graphType = DifferentialSolver.GraphType.NORMAL;
            if (chkUseXYLine.Checked == true)
            {
                graphType = DifferentialSolver.GraphType.CONNECT_XY;
            }
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, graphType);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnLorenz_Click(object sender, EventArgs e)
        {
            List<double> input_values = new List<double>();
            input_values.Add(1.0);
            input_values.Add(1.0);
            input_values.Add(1.0);

            List<List<double>> output = DifferentialSolver.Solve(input_values, TestEquations.lorenz, 0, 30, 30000);
            DifferentialSolver.GraphType graphType = DifferentialSolver.GraphType.NORMAL;
            if (chkUseXYLine.Checked == true)
            {
                graphType = DifferentialSolver.GraphType.CONNECT_XY;
            }
            DifferentialSolver.DrawGraph2D(Graphics.FromImage(drawImage), picCanvas.Width, picCanvas.Height, output, graphType);//Draw Graph
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }
    }
}
