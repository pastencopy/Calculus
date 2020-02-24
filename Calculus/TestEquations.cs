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

            result.Add(0); // y''은 측정불가
            result.Add(-y[1]);
            return result;
        }

        // Simple Differential Equation 5
        // y' = 1/y
        public static List<double> example5(double t, List<double> y)
        {
            List<double> result = new List<double>();

            result.Add(0); // y''은 측정불가
            result.Add(1 / y[1]);
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
