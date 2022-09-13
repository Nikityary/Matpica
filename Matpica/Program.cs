﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matpica
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Matrix matrica1 = new Matrix(3, 3);
            Matrix matrica2 = new Matrix(3, 3);
            Matrix matrica3 = new Matrix(3, 3);
            Matrix matrica4 = new Matrix(3, 3);
            Console.WriteLine("\nПервая матрица:\n");
            matrica1.PrintMatrix();
            Console.WriteLine("Вторая матрица:\n");
            matrica2.PrintMatrix();
            Console.WriteLine("Сумма матриц 1 и 2:\n");
            matrica1.Sum(matrica2);
            matrica1.PrintMatrix();
            Console.WriteLine("Результат умножения сложенных матриц на 2:\n");
            matrica1.MultiplyOnNumber(2);
            matrica1.PrintMatrix();
            Console.WriteLine("Третья матрица:\n");
            matrica3.PrintMatrix();
            Console.WriteLine("Четвёртая матрица:\n");
            matrica4.PrintMatrix();
            Console.WriteLine("Результат перемножения матриц 3 и 4:\n");
            matrica3.MultiplyOnMatrix(matrica4);
            matrica3.PrintMatrix();
            Console.ReadKey();
        }
    }
}
