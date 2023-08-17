using System.Runtime.Intrinsics.X86;
using System.Text;
using Domain.Models;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 1
//В одному з попередніх практичних завдань ви створю-
//вали клас «Співробітник». Додайте до вже створеного класу
//інформацію про заробітну плату працівника.Виконайте
//навантаження + (для збільшення зарплати на вказану кіль-
//кість), – (для зменшення зарплати на вказану кількість), ==
//(перевірка на рівність зарплат працівників), < і > (перевірка
//на меншу чи більшу кількість зарплат працівників), != і
//Equals.Використовуйте механізм властивостей полів класу.
            Console.WriteLine("Pract/Mod05/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Employee employee_1 = new Employee("Вячеслав", "Руднєв", "Михайлович", 27350);
                Employee employee_2 = new Employee("Євген", "Вус", "Петрович", 23200);
                Employee employee_3 = new Employee("Катерина", "Сорока", "Іванівна", 33125);
                
                //збільшення та зменшення зарплати працівників            
                Console.WriteLine();
                Console.WriteLine($"Працівник {employee_1.Name} {employee_1.Surname}, ставка {employee_1.Salary}");
                Console.WriteLine($"Збільшення на 1000: {employee_1 + 1000}");
                Console.WriteLine($"Зменшення на 3350: {employee_1 - 3350} \n");
                Console.WriteLine($"Працівник {employee_2.Name} {employee_2.Surname}, ставка {employee_2.Salary}");
                Console.WriteLine($"Збільшення на 8000: {employee_2 + 8000}");
                Console.WriteLine($"Зменшення на 6200: {employee_2 - 6200} \n");
                Console.WriteLine($"Працівник {employee_3.Name} {employee_3.Surname}, ставка {employee_3.Salary}");
                Console.WriteLine($"Збільшення на 3000: {employee_3 + 3000}");
                Console.WriteLine($"Зменшення на 2125: {employee_3 - 2125} \n");

                //перевірка на рівність та нерівність зарплат працівників ==, !=
                Console.WriteLine($"Порівняння зарплати: {employee_1 == employee_2}");
                Console.WriteLine($"Порівняння зарплати: {employee_1 == employee_3}");
                Console.WriteLine($"Порівняння зарплати: {employee_2 == employee_3}");
                Console.WriteLine();
                Console.WriteLine($"Порівняння зарплати: {employee_1 != employee_2}");
                Console.WriteLine($"Порівняння зарплати: {employee_1 != employee_3}");
                Console.WriteLine($"Порівняння зарплати: {employee_2 != employee_3}");
                Console.WriteLine();

                //порівняння зарплат працівників <, >
                Console.WriteLine($"Порівняння зарплати:" +
                    $" {((employee_1 > employee_3) ? ($"Заробітна плата у працівника {employee_1.Name} більша")
                    : ($"Заробітна плата у працівника {employee_3.Name} більша"))}");
                Console.WriteLine($"Порівняння зарплати:" +
                    $" {((employee_2 < employee_3) ? ($"Заробітна плата у працівника {employee_2.Name} менша")
                    : ($"Заробітна плата у працівника {employee_3.Name} менша"))}"); 
                
                Console.WriteLine();
                //порівняння зарплат працівників через Equals
                if (employee_1.Equals(employee_2))
                {
                    Console.WriteLine("Заробітні плати співпадають.");
                }
                else
                {
                    Console.WriteLine("Заробітні плати різні.");
                }

                if (employee_1.Equals(employee_3))
                {
                    Console.WriteLine("Заробітні плати співпадають.");
                }
                else
                {
                    Console.WriteLine("Заробітні плати різні.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}