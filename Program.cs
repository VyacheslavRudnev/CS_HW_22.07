using System.Text;
using Domain.Models;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 4
            //В одному з попередніх практичних завдань ви створю-
            //вали клас «Кредитна картка». Додайте до вже створеного
            //класу інформацію про суму грошей на картці.Виконай -
            //те перевантаження + (для збільшення суми грошей на
            //вказану кількість), – (для зменшення суми грошей на
            //вказану кількість), == (перевірка на рівність CVC коду),
            //< і > (перевірка на меншу чи більшу кількість суми гро -
            //шей), != і Equals.Використовуйте механізм властивостей
            //полів класу.

            Console.WriteLine("Pract/Mod05/ex04\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            CreditCard card1 = new CreditCard("1234 5678 9012 3456", "123", 1000.00);
            CreditCard card2 = new CreditCard("5678 9012 3456 7890", "123", 5000.00);
            CreditCard card3 = new CreditCard("9012 3456 7890 1234", "333", 10000.00);
            Console.WriteLine();

            Console.WriteLine($"Карта {card1.CardNumber}, баланс {card1.Balance}");
            Console.WriteLine($"Збільшення балансу на 5000,55: \n{card1 + 5000.55}");
            Console.WriteLine($"Зменшення балансу на 2250,05: \n{card1 - 2250.05} \n");
            Console.WriteLine($"Карта {card2.CardNumber}, баланс {card2.Balance}");
            Console.WriteLine($"Збільшення балансу на 2000,10: \n{card2 + 2000.10}");
            Console.WriteLine($"Зменшення балансу на 4500,05: \n{card2 - 4500.05} \n");
            Console.WriteLine($"Карта {card3.CardNumber}, баланс {card3.Balance}");
            Console.WriteLine($"Збільшення балансу на 2250,11: \n{card3 + 2250.11}");
            Console.WriteLine($"Зменшення балансу на 10250,01: \n{card3 - 10250.01}\n");

            //перевірка кодів CVC
            Console.WriteLine($"Порівняння карток: {card1 == card2}");
            Console.WriteLine($"Порівняння карток: {card1 == card3}");
            Console.WriteLine();
            Console.WriteLine($"Порівняння карток: {card1 != card2}");
            Console.WriteLine($"Порівняння карток: {card1 != card3}");
            Console.WriteLine();

            //порівняння балансів <, >
            Console.WriteLine($"Порівняння балансів:" +
                $" {((card1 > card2) ? ($"Баланс на картці {card1.CardNumber} більший")
                : ($"Баланс на картці {card2.CardNumber} більший"))}");
            Console.WriteLine($"Порівняння балансів:" +
                $" {((card2 > card3) ? ($"Баланс на картці {card2.CardNumber} менший")
                : ($"Баланс на картці {card3.CardNumber} менший"))}");

            //порівняння кодыв карток через Equals
            if (card1.Equals(card2))
            {
                Console.WriteLine("CVC коди карток співпадають.");
            }
            else
            {
                Console.WriteLine("CVC коди карток різні.");
            }

            if (card1.Equals(card3))
            {
                Console.WriteLine("CVC коди карток співпадають.");
            }
            else
            {
                Console.WriteLine("CVC коди карток різні.");
            }
            Console.ReadKey();

        }
    }
}