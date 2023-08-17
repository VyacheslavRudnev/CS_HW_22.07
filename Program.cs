using System.Text;
using Domain.Models;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 2
//В одному з попередніх практичних завдань ви ство-
//рювали клас «Матриця». Виконайте перевантаження +
//(для додавання матриць), – (для віднімання матриць). *
//(множення матриць одна на одну, множення матриці на
//число), == (перевірка матриць на рівність), != і Equals.
//Використовуйте механізм властивостей полів класу і ме -
//ханізм індексаторів.

            Console.WriteLine("Pract/Mod05/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Matrix matrix1 = new Matrix();
            Console.WriteLine("Вкажіть параметри матриці 1: ");
            matrix1.InputParam();
            Console.WriteLine();
            Matrix matrix2 = new Matrix();
            Console.WriteLine("Вкажіть параметри матриці 2: ");
            matrix2.InputParam();
            Console.WriteLine();
            Console.WriteLine("Матриця 1: ");
            matrix1.Show();
            Console.WriteLine();
            Console.WriteLine("Матриця 2: ");
            matrix2.Show();


        }
    }
}