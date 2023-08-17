using System.Text;
using Domain.Models;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3
//В одному з попередніх практичних завдань ви ство-
//рювали клас «Місто». Виконайте перевантаження +(для
//збільшення кількості жителів на вказану кількість), – (для
//зменшення кількості жителів на вказану кількість), ==
//(перевірка на рівність двох міст за кількістю жителів),
//< і > (перевірка на меншу чи більшу кількість мешкан-
//ців), != і Equals.Використовуйте механізм властивостей
//полів класу.

            Console.WriteLine("Pract/Mod05/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            City city1 = new City("Львів", 721300);
            City city2 = new City("Київ", 2884000);
            City city3 = new City("Хмельницький", 267000);

            Console.WriteLine($"City1: {city1.CityName}, {city1.Population}");
            Console.WriteLine($"Збільшення популяції на 100 000: {city1 + 100000}");
            Console.WriteLine($"Зменшення популяції на 21 300: {city1 - 21300} \n");
            Console.WriteLine($"City2: {city2.CityName}, {city2.Population}");
            Console.WriteLine($"Збільшення популяції на 116000: {city2 + 116000}");
            Console.WriteLine($"Зменшення популяції на 1 500 000: {city2 - 1500000} \n");
            Console.WriteLine($"City3: {city3.CityName}, {city3.Population}");
            Console.WriteLine($"Збільшення популяції на 600 000: {city3 + 600000}");
            Console.WriteLine($"Зменшення популяції на 67 000: {city3 - 67000} \n");

            Console.WriteLine($"Порівняння міст:" +
                    $" {((city1 > city2) ? ($"Популяція в місті {city1.CityName} більша ніж в місті {city2.CityName}")
                    : ($"Популяція в місті {city2.CityName} більша ніж в місті {city1.CityName}"))}");
            Console.WriteLine($"Порівняння міст:" +
                $" {((city2 < city3) ? ($"Популяція в місті {city2.CityName} менша ніж в місті {city3.CityName}")
                : ($"Популяція в місті {city3.CityName} менша ніж в місті {city2.CityName}"))}");
            Console.WriteLine();
            Console.WriteLine($"Порівняння рівності популяції міст {city1.CityName} і {city2.CityName}: {city1 == city2}");
            Console.WriteLine($"Порівняння рівності популяції міст {city1.CityName} і {city3.CityName}: {city1 == city3}");
            Console.WriteLine($"Порівняння рівності популяції міст {city2.CityName} і {city3.CityName}: {city2 == city3}");
            Console.WriteLine();
            Console.WriteLine($"Порівняння не рівності популяції міст {city1.CityName} і {city2.CityName}: {city1 != city2}");
            Console.WriteLine($"Порівняння не рівності популяції міст {city1.CityName} і {city3.CityName}: {city1 != city3}");
            Console.WriteLine($"Порівняння не рівності популяції міст {city2.CityName} і {city3.CityName}: {city2 != city3}");
            Console.WriteLine();
            //порівняння міст через Equals
            if (city1.Equals(city2))
            {
                Console.WriteLine($"Популяція міст {city1.CityName} і {city2.CityName} рівна");
            }
            else
            {
                Console.WriteLine($"Популяція міст {city1.CityName} і {city2.CityName} не рівна");
            }
            if (city1.Equals(city3))
            {
                Console.WriteLine($"Популяція міст {city1.CityName} і {city3.CityName} рівна");
            }
            else
            {
                Console.WriteLine($"Популяція міст {city1.CityName} і {city3.CityName} не рівна");
            }


        }
    }
}