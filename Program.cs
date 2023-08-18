using System.Text;
using Domain.Models;
using Internal;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3
//Створіть додаток «Список книг до прочитання». Додаток
//має дозволяти додавати книги до списку, видаляти книги
//зі списку, перевіряти чи є книга у списку, і т.д.Використо -
//вуйте механізм властивостей, навантаження операторів,
//індексаторів.

            Console.WriteLine("HW/Mod05/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            ReadingList myReadingList = new ReadingList();
            MenuManager menuManager = new MenuManager(myReadingList);
            menuManager.ShowMenu();


        }
    }
}