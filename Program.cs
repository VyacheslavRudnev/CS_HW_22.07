using System.Text;
using Domain.Models;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            //В одному з попередніх практичних завдань ви ство-
            //рювали клас «Журнал». Додайте до вже створеного класу
            //інформацію про кількість працівників.Виконайте наван-
            //таження + (для збільшення кількості працівників на вка -
            //зану кількість), — (для зменшення кількості працівників
            //на вказану кількість), == (перевірка на рівність кількості
            //працівників), < і > (перевірка на меншу чи більшу кіль -
            //кість працівників), != і Equals.Використовуйте механізм
            //властивостей полів класу.

            Console.WriteLine("HW/Mod05/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Magazine magazine1 = new Magazine("Журнал Мурзілка", 100);
            Magazine magazine2 = new Magazine("Журнал Forbs", 1000);
            Magazine magazine3 = new Magazine("Журнал Хакер", 25);

            Console.WriteLine($"{magazine1.MagazineName} має {magazine1.MemployeeNumbers} працівників");
            magazine1 += 25;
            Console.WriteLine($"Збільшення персоналу на 25 чоловік: {magazine1.MemployeeNumbers}");
            magazine1 -= 100;
            Console.WriteLine($"Зменшення персоналу на 100 чоловік: {magazine1.MemployeeNumbers}\n");
            Console.WriteLine($"{magazine2.MagazineName} має {magazine2.MemployeeNumbers} працівників");
            magazine2 += 250;
            Console.WriteLine($"Збільшення персоналу на 250 чоловік: {magazine2.MemployeeNumbers}");
            magazine2 -= 550;
            Console.WriteLine($"Зменшення персоналу на 500 чоловік: {magazine2.MemployeeNumbers}\n");
            Console.WriteLine($"{magazine3.MagazineName} має {magazine3.MemployeeNumbers} працівників");
            magazine3 += 5;
            Console.WriteLine($"Збільшення персоналу на 5 чоловік: {magazine3.MemployeeNumbers}");
            magazine3 -= 3;
            Console.WriteLine($"Зменшення персоналу на 3 чоловік: {magazine3.MemployeeNumbers}\n");
            Console.WriteLine("Перевірка на рівність кількості працівників, оператор ==");
            Console.WriteLine($"Порівняння: {magazine1 == magazine2}");
            Console.WriteLine($"Порівняння: {magazine1 == magazine3}");
            Console.WriteLine($"Порівняння: {magazine2 == magazine3}\n");
            Console.WriteLine("оператор !=");
            Console.WriteLine($"Порівняння: {magazine1 != magazine2}");
            Console.WriteLine($"Порівняння: {magazine1 != magazine3}");
            Console.WriteLine($"Порівняння: {magazine2 != magazine3}\n");
            Console.WriteLine("Порівняння через метод Equals");
            Console.WriteLine($"Порівняння: {magazine1.Equals(magazine2)}");
            Console.WriteLine($"Порівняння: {magazine1.Equals(magazine3)}");
            Console.WriteLine($"Порівняння: {magazine2.Equals(magazine3)}");
            Console.WriteLine();
            //порівняння кількості працівників <, >
            Console.WriteLine($"Порівняння кількості працівників:" +
                $" {((magazine1 > magazine3) ? ($"В {magazine1.MagazineName} працівників більше ніж в {magazine3.MagazineName}")
                : ($"В {magazine3.MagazineName} працівників більше ніж в {magazine1.MagazineName}"))}");
            Console.WriteLine($"Порівняння кількості працівників:" +
                $" {((magazine2 < magazine3) ? ($"В {magazine2.MagazineName} працівників менше ніж в {magazine3.MagazineName}")
                : ($"В {magazine3.MagazineName} працівників менше ніж в {magazine2.MagazineName}"))}");

        }
    }
}