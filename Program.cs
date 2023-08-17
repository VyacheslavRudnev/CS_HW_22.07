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
            Console.WriteLine("Матриця 1: ");
            matrix1.Show();
            Console.WriteLine();
            Matrix matrix2 = new Matrix();
            Console.WriteLine("Вкажіть параметри матриці 2: ");
            matrix2.InputParam();
            Console.WriteLine();
            Console.WriteLine("Матриця 2: ");
            matrix2.Show();
            //перевантаження +
            Console.WriteLine();
            Console.WriteLine("Перевантаження +: ");
            Matrix matrix3 = matrix1 + matrix2;
            Console.WriteLine("Матриця 3: ");
            matrix3.Show();
            //перевантаження -
            Console.WriteLine();
            Console.WriteLine("Перевантаження -: ");
            Matrix matrix4 = matrix1 - matrix2;
            Console.WriteLine("Матриця 4: ");
            matrix4.Show();
            //перевантаження *
            Console.WriteLine();
            Console.WriteLine("Перевантаження *: ");
            Matrix matrix5 = matrix1 * matrix2;
            Console.WriteLine("Матриця 5: ");
            matrix5.Show();
            Console.WriteLine();
            Console.WriteLine("Перевантаження * на число: ");
            Matrix matrix6 = matrix1 * 2;
            Console.WriteLine("Матриця 6: ");
            matrix6.Show();

            //перевантаження == і !=
            Console.WriteLine();
            Console.WriteLine("Перевантаження == і !=: ");
            Matrix matrix7 = new Matrix(2, 2);
            Console.WriteLine("Вкажіть параметри матриці 7: ");
            matrix7.InputElem();
            Console.WriteLine();
            Console.WriteLine("Матриця 7: ");
            matrix7.Show();
            Console.WriteLine();
            Matrix matrix8 = new Matrix(2, 2);
            Console.WriteLine("Вкажіть параметри матриці 8: ");
            matrix8.InputElem();
            Console.WriteLine();
            Console.WriteLine("Матриця 8: ");
            matrix8.Show();
            Console.WriteLine();
            if (matrix7 == matrix8)
            {
                Console.WriteLine("Матриці 7 та 8 рівні");
            }
            else
            {
                Console.WriteLine("Матриці 7 та 8 не рівні");
            }
            if (matrix7 != matrix8)
            {
                Console.WriteLine("Матриці 7 та 8 не рівні");
            }
            else
            {
                Console.WriteLine("Матриці 7 та 8 рівні");
            }
            if (matrix7 == matrix1)
            {
                Console.WriteLine("Матриці 7 та 1 рівні");
            }
            else
            {
                Console.WriteLine("Матриці 7 та 1 не рівні");
            }






        }
    }
}