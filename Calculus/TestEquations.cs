/*
 * Test Differential Equation
 * 
 *  2020 Coded By GwangSu Lee
 *  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus
{
    public class TestEquations
    {
        private static TestEquations _inst = new TestEquations();
        private TestEquations()
        {

        }

        // Simple Differential Equation 1
        // y' = 2y
        public static List<double> example1(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(2.0 * y[0]);

            return result;
        }

        // Simple Differential Equation 2
        // y' = 2
        public static List<double> example2(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(2.0);

            return result;
        }

        // Simple Differential Equation 3
        // y' = cos(x)
        public static List<double> example3(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(Math.Cos(t));
            return result;
        }

        // Simple Differential Equation 4
        // y' = -y
        public static List<double> example4(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(-y[0]);
            return result;
        }

        // Simple Differential Equation 5
        // y' = 1/y
        public static List<double> example5(double t, List<double> y)
        {
            List<double> result = new List<double>();
            result.Add(1 / y[0]);
            return result;
        }

        // Simple Differential Equation 6
        // y' = cos(x) + sin(x)
        public static List<double> example6(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(Math.Cos(t) + Math.Sin(t));
            return result;
        }

        // Simple Differential Equation 7
        // y' = e + sin(x)
        public static List<double> example7(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(Math.E + Math.Sin(t));
            return result;
        }

        // Simple Differential Equation 8
        // du/dt = 3u + 4v
        // dv/dt = -4u + 3v
        public static List<double> example8(double t, List<double> y)
        {
            List<double> result = new List<double>();

            // du/dt = 3u + 4v
            // dv/dt = -4u + 3v
            result.Add(  3.0*y[0] + 4.0*y[1]);
            result.Add( -4.0*y[0] + 3.0*y[1]);
            return result;
        }


        // Simple Differential Equation 9
        // y' = x^2-2*x+1
        public static List<double> example9(double t, List<double> y)
        {
            List<double> result = new List<double>();
            result.Add(t*t  - (2.0*t) + 1);
            return result;
        }

        // Simple Differential Equation 10
        // y' = 2x
        public static List<double> example10(double t, List<double> y)
        {
            List<double> result = new List<double>();
            result.Add(2.0 * t);
            return result;
        }

        // Simple Differential Equation 11
        // y' = x^(-2)
        public static List<double> example11(double t, List<double> y)
        {
            List<double> result = new List<double>();
            result.Add(Math.Pow(t,-2.0));
            return result;
        }

        // Simple Differential Equation 12
        //
        // d2y/dt2 = 1/(t+1)   +   sin(t)*sqrt(t)
        // y(0) = 0
        // dydt(0) = -2
        public static List<double> example12(double t, List<double> y)
        {
            List<double> result = new List<double>();
            result.Add(y[1]); // x
            result.Add(1/(t+1) + Math.Sin(t)*Math.Sqrt(t)); // dx
            return result;
        }

        // Simple Differential Equation 13
        //
        // dx = -y - x^2
        // dy = 2x - y^3
        public static List<double> example13(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add( -y[1] - (y[0]* y[0]) ); // x
            result.Add( 2*y[0] - (y[1]* y[1]* y[1])); // dx
            return result;
        }

        //
        // Lorenz system
        //
        //https://en.wikipedia.org/wiki/Lorenz_system
        public static List<double> lorenz(double t, List<double> y)
        {
            List<double> result = new List<double>();

            //const double sigma = 0.35323;
            //const double beta = 0.28016;
            //const double plastic = 1.32471;

            const double sigma = 10;
            const double beta = 8/3;
            const double plastic = 28;

            result.Add(sigma * (y[1] - y[0]));
            result.Add(y[0] * (plastic - y[2]) - y[1]);
            result.Add(y[0] * y[1]  - beta * y[2]);
            return result;
        }

        // predator–prey equations
        // https://en.wikipedia.org/wiki/Lotka%E2%80%93Volterra_equations
        public static List<double> predatorprey(double t, List<double> y)
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

            result.Add(a * y[0] - b * y[0] * y[1]); //Prey
            result.Add(d * y[0] * y[1] - c * y[1]); //Predators

            return result;
        }
    }
}
