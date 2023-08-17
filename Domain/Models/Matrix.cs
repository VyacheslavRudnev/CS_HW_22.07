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
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1._rows, matrix1._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix1._columns; j++) matrix._matrix[i, j] = matrix1._matrix[i, j] + matrix2._matrix[i, j];
            }
            return matrix;
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1._rows, matrix1._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix1._columns; j++) matrix._matrix[i, j] = matrix1._matrix[i, j] - matrix2._matrix[i, j];
            }
            return matrix;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1._rows, matrix2._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix2._columns; j++)
                {
                    matrix._matrix[i, j] = 0;
                    for (int k = 0; k < matrix1._columns; k++) matrix._matrix[i, j] += matrix1._matrix[i, k] * matrix2._matrix[k, j];
                }
            }
            return matrix;
        }
        public static Matrix operator *(Matrix matrix1, int number)
        {
            Matrix matrix = new Matrix(matrix1._rows, matrix1._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix1._columns; j++) matrix._matrix[i, j] = matrix1._matrix[i, j] * number;
            }
            return matrix;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Matrix otherMatrix = (Matrix)obj;

            if (_rows != otherMatrix._rows || _columns != otherMatrix._columns)
                return false;

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (_matrix[i, j] != otherMatrix._matrix[i, j])
                        return false;
                }
            }

            return true;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2))
                return true;

            if (matrix1 is null || matrix2 is null)
                return false;

            return matrix1.Equals(matrix2);
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }
    }
}
