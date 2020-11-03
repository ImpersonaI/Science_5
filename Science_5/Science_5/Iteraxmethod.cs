using System;
using System.Collections.Generic;
using System.Text;

namespace Science_5
{
    class Iteraxmethod
    {

        double[,] A =
            {

            {0.08, 0.064, 0.9, 0.75},

            {0.06, 0.467, 0.107, 0.4},

            {1.65, 0.533, 0.094, 0.277},

            {0.046, 0.85, 0.2, 0.4}

            };

        double[] b = { 9.592, 6.862, 32.278, 10.198 };

        double[,] C =
            {

            {0, 0, 0, 0},

            {0, 0, 0, 0},

            {0, 0, 0, 0},

            {0, 0, 0, 0}

            };

        double[] d = { 0, 0, 0, 0};
        double[] x = { 0, 0, 0, 0 };

        public void dointexmethod()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    d[i] = b[i] / A[i, i];
                    C[i, j] = -(A[i,j] / A[i,i]);
                    
                    
                    //Console.WriteLine();
                   // Console.Write(C[i,j] + "\t");
                   

                }
                C[i, i] = 0;
                //Console.WriteLine();
                x[i] = d[i];

            }

            Console.WriteLine("C =");

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("D =");

            for (int i = 0; i < 3; i++)
            {
                
                Console.Write(d[i] + "\t");
                           
            }

            Console.WriteLine();



        }
    }
}
