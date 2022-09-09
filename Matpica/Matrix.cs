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
        public int k, t, i, j;
        double[,] DoubleArray;
        int n, m;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            DoubleArray = new double[n, m];
        }

        //ПЕРВАЯ МАТРИЦА
        // Ввести элементы
        public void EnterElements()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Введите элемнет [{0},{1}] :  ", i, j);
                    DoubleArray[i, j] = Double.Parse(Console.ReadLine());
                }
            }
        }

        // Вывести элементы матрицы на экран
        public void PrintMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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
            for (int k = 0; k < n; k++)
            {
                for (int t = 0; t < m; t++)
                {
                    Console.Write("Введите элемнет [{0},{1}] :  ", k, t);
                    DoubleArray[k, t] = Double.Parse(Console.ReadLine());
                }
            }
        }

        // Вывести элементы матрицы на экран
        public void PrintMatrix2()
        {
            for (int k = 0; k < n; k++)
            {
                for (int t = 0; t < m; t++)
                {
                    Console.Write(DoubleArray[k, t] + " ");
                }
                Console.WriteLine();
            }
        }

        //Сложение матриц 1 и 2
        public void Plus()
        {
            for (int z = 0; z < n; z++)
            {
                for (int c = 0; c < m; c++)
                {
                    int[,] mat3 = new int[z, c];
                     DoubleArray[z, c] = DoubleArray[k, t] + DoubleArray[i, j];
                }
                Console.WriteLine();
            }
        }
        // Вывести результат на экран
        public void PrintMatrix3()
        {
            for (int z = 0; z < n; z++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(DoubleArray[z, c] + " ");
                }
                Console.WriteLine();
            }
        }

        // Умножение
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
