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
        int n, m, i, j, k, t, z, c;

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
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("Введите элемнет [{0},{1}] :  ", i, j);
                    DoubleArray[i, j] = Double.Parse(Console.ReadLine());
                }
            }
        }

        // Вывести элементы матрицы на экран
        public void PrintMatrix()
        {
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(DoubleArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //ВТОРАЯ МАТРИЦА
        // Ввести элементы
        public void EnterElements2()
        {
            for (k = 0; k < n; k++)
            {
                for (t = 0; t < m; t++)
                {
                    Console.Write("Введите элемнет [{0},{1}] :  ", k, t);
                    DoubleArray2[k, t] = Double.Parse(Console.ReadLine());
                }
            }
        }

        // Вывести элементы матрицы на экран
        public void PrintMatrix2()
        {
            for (k = 0; k < n; k++)
            {
                for (t = 0; t < m; t++)
                {
                    Console.Write(DoubleArray2[k, t] + " ");
                }
                Console.WriteLine();
            }
        }

        //Сложение матриц 1 и 2
        public void Plus()
        {
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    DoubleArray3[z, c] = DoubleArray[i, j] + DoubleArray2[k, t];
                }
            }
        }
        // Вывести результат на экран
        public void PrintMatrix3()
        {
            for (z = 0; z < n; z++)
            {
                for (c = 0; c < m; c++)
                {
                    Console.Write(DoubleArray3[z, c] + " ");
                }
                Console.WriteLine();
            }
        }

        // Умножение на число
        public double Multiply
        {
            set
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        DoubleArray[i, j] *= value;
                    }
                }
            }
        }
    }
}
