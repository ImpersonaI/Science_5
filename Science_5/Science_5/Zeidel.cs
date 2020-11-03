using System;
using System.Collections.Generic;
using System.Text;

namespace Science_5
{
    class Zeidel
    {
            
        double[,] A =
            {

            {1600, 1, -2},

            {8, 3200, 2},

            {6, -6, 4800}

            };

        double[] b = { 1618, 5121, -4890};

        double[,] C =
            {

            {0, 0, 0, 0},

            {0, 0, 0, 0},         

            {0, 0, 0, 0}

            };

        double[] d = { 0, 0, 0};

        double[,] C1 =
            {

            {0, 0, 0, 0},

            {0, 0, 0, 0},

            {0, 0, 0, 0}

            };

        double[,] C2 =
            {

            {0, 0, 0, 0},

            {0, 0, 0, 0},

            {0, 0, 0, 0}

            };

        public void DoZeidel()
        {

            for (int i = 0; i < 3; i++)
            {

                d[i] = b[i] / A[i, i];
            }

            for (int i = 1; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    C1[i, j] = -(A[i, j] / A[i, i]);
                    C2[j, i] = -(A[j, i] / A[j, j]);
                    C1[i, i] = 0;
                    C1[j, i] = 0;
                    C2[i, i] = 0;
                    C2[i, i] = 0;
                    C[i, j] = C1[i, j] + C2[i, j];
                }             

            }

            Console.WriteLine("C = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("C1 = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C1[i, j] + "\t");
                }
                Console.WriteLine();

            }

            Console.WriteLine("C2 = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("d = ");
            for (int i = 0; i < 3; i++)
            {
               
                    Console.Write(d[i] + "\t");
                
                Console.WriteLine();
            }

        }
    }
}
