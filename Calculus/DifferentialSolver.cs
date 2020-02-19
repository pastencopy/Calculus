/*
 * 
 * 편미분 솔루션
 * 
 * Runge–Kutta methods : https://en.wikipedia.org/wiki/Runge%E2%80%93Kutta_methods
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus
{
    public class DifferentialSolver
    {
        private static DifferentialSolver _inst = new DifferentialSolver();
        private DifferentialSolver() { }

        private static List<double> AddListValue(List<double> original, List<double> other)
        {
            List<double> result = new List<double>(original);
            for(int i = 0; i < original.Count; i++)
            {
                result[i] += other[i];
            }
            return result;
        }

        private static List<double> ScalarMultiListValue(double scalar, List<double> original)
        {
            List<double> result = new List<double>(original);
            for(int i = 0; i< result.Count; i++)
            {
                result[i] *= scalar;
            }
            return result;
        }
        public static List<List<double>> Solve(
            List<double> init_values,
            Func<double, List<double>, List<double>> func, // y' =  f(t, Y[])
            int t0 = 0, int tN = 10, int t_interval = 100 // 시작값,종료값,간격
            )
        {
            double h = (tN - t0) / (double)t_interval; //시간 변화량 ( dt == h )

            List<List<double>> outputs = new List<List<double>>();

            List<double> oldY = new List<double>(init_values);

            for (int i = 0; i < t_interval; i++)
            {
                /*
                 * 
                 * The Runge–Kutta method
                 * 
                 * 
                 */


                //t[n+1] = t[n] + h
                double t = t0 + (i * h);

                //k1 = h x f(t , y)
                List<double> k1 = new List<double>(func(t, oldY));
                k1 = ScalarMultiListValue(h, k1);

                //k2 = h x f(t + h/2 , y + k1/2)
                List<double> k2 = func(t + (h * 0.5), AddListValue(oldY, ScalarMultiListValue(0.5, k1)));
                k2 = ScalarMultiListValue(h, k2);

                //k3 = h x f(t + h/2 , y + k2/2)
                List<double> k3 = func(t + (h * 0.5), AddListValue(oldY, ScalarMultiListValue(0.5, k2)));
                k3 = ScalarMultiListValue(h, k3);

                //k4 = h x f(t + h , y + k3)
                List<double> k4 = func(t + (h * 0.5), AddListValue(oldY, ScalarMultiListValue(0.5, k3)));
                k4 = ScalarMultiListValue(h, k4);

                //yn + 1/6 * (k1 + 2*k2 + 2*k3 + k4)
                k1 = AddListValue(k1, ScalarMultiListValue(2.0, k2));
                k4 = AddListValue(k4, ScalarMultiListValue(2.0, k3));
                k1 = AddListValue(k1, k4);
                k1 = ScalarMultiListValue(1 / 6.0, k1);

                //result
                List<double> y = AddListValue(oldY, k1);
                outputs.Add(y);

                oldY = new List<double>(y);
            }

            return outputs;
        }
    }
}
