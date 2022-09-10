using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matpica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix mat1 = new Matrix(3, 3);
            mat1.EnterElements(); //Ввести элементы матрицы
            Console.WriteLine(new string('-', 35));
            mat1.PrintMatrix(); //Отобразить матрицу
            Console.WriteLine(new string('-', 35));


            Matrix mat2 = new Matrix(3, 3);
            mat2.EnterElements2(); //Ввести элементы матрицы 2
            Console.WriteLine(new string('-', 35));
            mat2.PrintMatrix2(); //Отобразить матрицу 2
            Console.WriteLine(new string('-', 35));

           // Matrix mat3 = new Matrix(3, 3);
           // mat3.Plus();
           // mat3.PrintMatrix3(); //Отобразить матрицу 3
           // Console.WriteLine(new string('-', 35));


            Console.Write("Введите множитель: ");
            mat1.Multiply = Double.Parse(Console.ReadLine());
            mat1.PrintMatrix(); //Отобразить матрицу
            Console.WriteLine(new string('-', 35));
            Console.ReadKey();

            Matrix mat3 = new Matrix(3, 3);
            Console.WriteLine("Результат перемножения матриц: ");
            mat3.Umn();
            Console.WriteLine(new String('-', 35));

            Console.ReadKey();
        }
    }
}
