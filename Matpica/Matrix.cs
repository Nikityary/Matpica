using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matpica
{
    internal class Matrix
    {
        double[,] DoubleArray;
        double[,] DoubleArray2;
        double[,] DoubleArray3;
        int n, m;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            DoubleArray = new double[n, m];
            DoubleArray2 = new double[n, m];
            DoubleArray3 = new double[n, m];
        }

        //ПЕРВАЯ МАТРИЦА
        // Ввести элементы
        public void EnterElements()
        {
            for (int z = 0; z < n; z++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write("Введите элемнет [{0},{1}] :  ", z, k);
                    DoubleArray[z, k] = Double.Parse(Console.ReadLine());
                }
            }
        }

        // Вывести элементы матрицы на экран
        public void PrintMatrix()
        {
            for (int z = 0; z < n; z++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write(DoubleArray[z, k] + " ");
                }
                Console.WriteLine();
            }
        }

        //ВТОРАЯ МАТРИЦА
        // Ввести элементы
        public void EnterElements2()
        {
            for (int k = 0; k < n; k++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write("Введите элемнет [{0},{1}] :  ", k, c);
                    DoubleArray2[k, c] = Double.Parse(Console.ReadLine());
                }
            }
        }

        // Вывести элементы матрицы на экран
        public void PrintMatrix2()
        {
            for (int k = 0; k < n; k++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(DoubleArray2[k, c] + " ");
                }
                Console.WriteLine();
            }
        }

        //Сложение матриц 1 и 2
 //       public void Plus()
 //       {
 //           for (i = 0; i < n; i++)
 //           {
 //               for (j = 0; j < m; j++)
 //               {
 //                   DoubleArray3[z, c] = DoubleArray[i, j] + DoubleArray2[k, t];
 //               }
 //           }
 //       }
        // Вывести результат на экран
 //       public void PrintMatrix3()
 //       {
 //           for (z = 0; z < n; z++)
 //           {
 //               for (c = 0; c < m; c++)
 //               {
 //                   Console.Write(DoubleArray3[z, c] + " ");
 //               }
 //               Console.WriteLine();
 //           }
 //       }

        // Умножение на число
        public double Multiply
        {
            set
            {
                for (int z = 0; z < n; z++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        DoubleArray[z, k] *= value;
                    }
                }
            }
        }
        public void Umn()
        {
            for (int z = 0; z < DoubleArray.GetLength(0); z++)
            {
                for (int c = 0; c < DoubleArray2.GetLength(1); c++)
                {
                    for (int k = 0; k < DoubleArray2.GetLength(0); k++)
                    {
                        DoubleArray3[z, c] += DoubleArray[z, k] * DoubleArray2[k, c];
                        Console.Write(DoubleArray3[z, c] + " ");
                    }
                }
            }
        }
    }
}