using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Domain.Models
{
//Завдання 2
//виконайте перевантаження +
//(для додавання матриць), – (для віднімання матриць). *
//(множення матриць одна на одну, множення матриці на
//число), == (перевірка матриць на рівність), != і Equals. 
//Використовуйте механізм властивостей полів класу і ме-
//ханізм індексаторів.
    public class Matrix
    {
        private int[,] _matrix;
        private int _rows;
        private int _columns;

        public int Rows { get => _rows; set => _rows = value; }
        public int Columns { get => _columns; set => _columns = value; }

        public Matrix() { }

        public Matrix(int _rows, int _columns)
        {
            this._rows = _rows;
            this._columns = _columns;
            _matrix = new int[_rows, _columns];
        }
        public void InputParam()
        {
            Console.WriteLine("Введіть кількість рядків: ");
            _rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців: ");
            _columns = int.Parse(Console.ReadLine());
            _matrix = new int[_rows, _columns];
            Random rand = new Random();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++) _matrix[i, j] = rand.Next(0, 10);
            }
        }
        public void InputElem()
        {
            Console.WriteLine("Введіть елементи матриці: ");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++) _matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        public void Show()
        {
            Console.WriteLine("Ваша матриця: ");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++) Console.Write($"{_matrix[i, j]} \t");
                Console.WriteLine();
            }
        }
        public void ShowMaxElem()
        {
            
            int max = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++) if (_matrix[i, j] > max) max = _matrix[i, j];
            }
            Console.WriteLine($"Найбільший елемент матриці: {max}");
        }
        public void ShowMinElem()
        {
            int min = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++) if (_matrix[i, j] < min) min = _matrix[i, j];
            }
            Console.WriteLine($"Найменший елемент матриці: {min}");
        }


    }
}
