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
//рювали клас «Магазин». Додайте до вже створеного класу
//інформацію про площу магазину.Виконайте наванта-
//ження + (для збільшення площі магазину на вказаний
//розмір), — (для зменшення площі магазину на вказаний
//розмір), == (перевірка на рівність площ магазинів), < і >
//(перевірка магазинів менших або більших за площею),
//!= і Equals.Використовуйте механізм властивостей
//полів класу.

            Console.WriteLine("HW/Mod05/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Shop shop1 = new Shop("Фора", 1500);
            Shop shop2 = new Shop("Кав'ярня", 40);
            Shop shop3 = new Shop("Епіцентр", 25000);

            Console.WriteLine($"{shop1.ShopName} має площу {shop1.ShopSquare} метрів квадратних");
            Console.WriteLine($"Збільшення площі на 100 метрів: {shop1 + 100}");
            Console.WriteLine($"Зменшення площі на 500 метрів: {shop1 - 500}\n");
            Console.WriteLine($"{shop2.ShopName} має площу {shop2.ShopSquare} метрів квадратних");
            Console.WriteLine($"Збільшення площі на 11 метрів: {shop2 + 11}");
            Console.WriteLine($"Зменшення площі на 8 метрів: {shop2 - 8}\n");
            Console.WriteLine($"{shop3.ShopName} має площу {shop3.ShopSquare} метрів квадратних");
            Console.WriteLine($"Збільшення площі на 10 000 метрів: {shop3 + 10000}");
            Console.WriteLine($"Зменшення площі на 20 000 метрів: {shop3 - 20000}\n");
            Console.WriteLine("Перевірка на рівність площі, оператор ==");
            Console.WriteLine($"Порівняння: {shop1 == shop2}");
            Console.WriteLine($"Порівняння: {shop1 == shop3}");
            Console.WriteLine($"Порівняння: {shop2 == shop3}\n");
            Console.WriteLine("Перевірка на нерівність площі, оператор !=");
            Console.WriteLine($"Порівняння: {shop1 != shop2}");
            Console.WriteLine($"Порівняння: {shop1 != shop3}");
            Console.WriteLine($"Порівняння: {shop2 != shop3}\n");
            Console.WriteLine("Порівняння через метод Equals");
            Console.WriteLine($"Порівняння: {shop1.Equals(shop2)}");
            Console.WriteLine($"Порівняння: {shop1.Equals(shop3)}");
            Console.WriteLine($"Порівняння: {shop2.Equals(shop3)}");
            Console.WriteLine();
            //порівняння розмірів магазинів <, >
            Console.WriteLine($"Порівняння розмірів магазинів:" +
                $" {((shop1 > shop2) ? ($"Площа магазину {shop1.ShopName} більша ніж площа магазину {shop2.ShopName}")
                : ($"Площа магазину {shop2.ShopName} більша ніж площа магазину {shop1.ShopName}"))}");
            Console.WriteLine($"Порівняння розмірів магазинів:" +
                $" {((shop1 < shop3) ? ($"Площа магазину {shop1.ShopName} менша ніж площа магазину {shop3.ShopName}")
                : ($"Площа магазину {shop3.ShopName} менша ніж площа магазину {shop1.ShopName}"))}");

        }
    }
}