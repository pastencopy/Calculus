﻿/*
 * 
 * 미분 솔루션
 * 
 * 상미분 방정식을 롱게-쿠타 방식으로 근사혜를 구합니다.
 * 
 * 2020 Coded by GwangSu Lee
 * 
 * Runge–Kutta methods : https://en.wikipedia.org/wiki/Runge%E2%80%93Kutta_methods
 * Lorenz system : https://en.wikipedia.org/wiki/Lorenz_system
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus
{
    public class DifferentialSolver
    {
        public enum GraphType
        {
            NORMAL,
            CONNECT_XY,
        }

        private static DifferentialSolver _inst = new DifferentialSolver();
        private DifferentialSolver() { }

        //배열의 합
        private static List<double> AddListValue(List<double> original, List<double> other)
        {
            List<double> result = new List<double>(original);
            for(int i = 0; i < original.Count; i++)
            {
                result[i] += other[i];
            }
            return result;
        }

        //배열의 스칼라 곱
        private static List<double> ScalarMultiListValue(double scalar, List<double> original)
        {
            List<double> result = new List<double>(original);
            for(int i = 0; i< result.Count; i++)
            {
                result[i] *= scalar;
            }
            return result;
        }

        /*
         *    Solve()
         *    
         *      init_values : 초기 Y 값
         *      func        : 미분 방정식
         *      t0          : t의 범위 시작
         *      tN          : t의 범위 끝
         *      t_interval  : dt 간격
         *    
         *    return output (룽게쿠타를 이용한 미분방정식 결과값)
         *    
         *    
         *    미분 방정식을    f'(t,y) = 2y + t    이라 했을 때,
         *    미분함수의 원형은 func(t , y)
         *    입력이 2개 이상인 경우 y[] 배열로 연산
         *    
         *    ex)
         *           y0 = 0 ,    f(t, y) = 2y
         * 
         *           
         *           
         *           func(double t, double y)
         *           {
         *               return 2*y
         *           }
         *           
         *           
         *           init_values = [ 0 ]
                     range t = 0 ~ 3
         *           interval = 100000
         *           
         *           output = Solve(0, func , 0, 3 , 100000)
         *           
         *           
         * */

        public static List<List<double>> Solve(
            List<double> init_values,                       // 초기 Y 값
            Func<double, List<double>, List<double>> func,  // 미분 방정식 y' =  f(t, Y[])
            int t0 = 0, int tN = 10, int t_interval = 10000 // dt의 시작~종료 구간 및 간격, (단 tN > t0)
            )
        {

            if (t0 > tN || t_interval < 1)
            {
                throw new Exception("초기값이 잘못 되었습니다.");
            }

            double h = (tN - t0) / (double)t_interval; //시간 변화량, 변수명은 룽게쿠타 방식에서의 ( dt == h ) 와 같다

            List<List<double>> outputs = new List<List<double>>();

            List<double> oldY = new List<double>(init_values);

            for (int i = 0; i < t_interval; i++)
            {
                /*
                 * 
                 * The Runge–Kutta method 를 이용하여 미분 방정식의 해를 구함
                 * 
                 * https://en.wikipedia.org/wiki/Runge%E2%80%93Kutta_methods
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

                //결과값
                List<double> y = AddListValue(oldY, k1);
                outputs.Add(y);

                oldY = new List<double>(y);
            }

            return outputs;
        }

        /*
         *    DrawGraph2D()
         *    
         *    
         *    yaxies : 미분방정식으로 구한 y좌표 값
         *    
         *    
         *    
         */

        public static void DrawGraph2D(Graphics g, int width, int height, List<List<double>> yaxies , GraphType graphType = GraphType.NORMAL)
        {
            if (graphType == GraphType.CONNECT_XY )
            {
                DrawGraph2DLine(g, width, height, yaxies);
            }
            else if (graphType == GraphType.NORMAL)
            {
                DrawGraph2DNormal(g, width, height, yaxies);
            }
        }

           
        private static void DrawGraph2DNormal(Graphics g, int width, int height, List<List<double>> yaxies)
        {
            //XY축 최대값
            double minY = 0.0;
            double maxY = 0.0;
            yaxies.ForEach(
                (item) => {
                    item.ForEach(
                        (subitem) =>
                        {
                            if (maxY <= subitem) { maxY = subitem; }
                            if (minY >= subitem) { minY = subitem; }
                        }
                    );
                });

            const int marginX = 10;
            const int marginY = 10;
            const int dotSize = 3;

            float graph_y_length = height - marginY;                //y축 길이
            float graph_x_length = width - marginX;                 //x축길이

            float scaleY = graph_y_length / (float)(maxY - minY); //y축 1칸당 크기
            float scaleX = graph_x_length / yaxies.Count;         //x축 1칸당 크기

            g.TranslateTransform(0, (float)(scaleY * (minY))); //좌표 이동 0,0
            g.Clear(Color.White);
            g.DrawLine(Pens.Silver, -graph_x_length, graph_y_length, graph_x_length, graph_y_length); // x축
            g.DrawLine(Pens.Silver, marginX, graph_y_length * 2, marginX, marginY); // y축

            Color[] colorlist = { Color.DodgerBlue, Color.OrangeRed, Color.Green, Color.Purple, Color.DarkGray };

            for (int i = 0; i < yaxies.Count; i++)
            {
                List<double> item = yaxies[i];
                for (int j = 0; j < item.Count; j++)
                {
                    double y = item[j];
                    int posX = marginX + (int)(scaleX * i);
                    int posY = (int)(graph_y_length - (scaleY * y)); //y 좌표계가 반대방향

                    Brush brush = new SolidBrush(colorlist[j]);
                    g.FillEllipse(brush, posX, posY, dotSize, dotSize);
                }
            }

        }

        private static void DrawGraph2DLine(Graphics g, int width, int height, List<List<double>> yaxies)
        {
            //XY축 최대값
            double minY = 0.0;
            double maxY = 0.0;
            yaxies.ForEach(
                (item) => {
                    item.ForEach(
                        (subitem) =>
                        {
                            if (maxY <= subitem) { maxY = subitem; }
                            if (minY >= subitem) { minY = subitem; }
                        }
                    );
                });

            const int marginX = 10;
            const int marginY = 10;
            const int dotSize = 3;

            float graph_y_length = height - marginY;                //y축 길이
            float graph_x_length = width - marginX;                 //x축길이

            float scaleY = graph_y_length / (float)(maxY - minY); //y축 1칸당 크기
            float scaleX = graph_x_length / (float)(maxY - minY);         //x축 1칸당 크기

            g.TranslateTransform(-(float)(scaleY * (minY)), (float)(scaleY * (minY))); //좌표 이동 0,0
            g.Clear(Color.White);
            g.DrawLine(Pens.Silver, -graph_x_length, graph_y_length, graph_x_length, graph_y_length); // x축
            g.DrawLine(Pens.Silver, marginX, graph_y_length * 2, marginX, marginY); // y축

            Color[] colorlist = { Color.DodgerBlue, Color.OrangeRed, Color.Green, Color.Purple, Color.DarkGray };

            for (int i = 0; i < yaxies.Count; i++)
            {
                List<double> item = yaxies[i];

                int posX = marginX + (int)(scaleX * item[0]);
                int posY = (int)(graph_y_length - (scaleY * item[1])); //y 좌표계가 반대방향

                Brush brush = new SolidBrush(colorlist[0]);
                g.FillEllipse(brush, posX, posY, dotSize, dotSize);

            }
        }

    }
}
