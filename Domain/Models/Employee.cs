using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _dateOfBirth;
        private string _phoneNumber;
        private string _email;
        private string _position;
        private string _jobDescription;
        private int _salary;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Patronymic
        {
            get { return (_patronymic is null) ? throw new ArgumentNullException("По батькові не задано") : _patronymic; }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("По батькові не задано");
                else
                    _patronymic = value;
            }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length != 12)
                {
                    throw new ArgumentException("Номер телефону повинен містити 12 символів");
                }
                else
                {
                    long number = Convert.ToInt64(value);
                    _phoneNumber = number.ToString("+## (###) ###-##-##");
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string JobDescription
        {
            get { return _jobDescription; }
            set { _jobDescription = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee() { }

        public Employee(string name, string surname, string patronymic, int salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Salary = salary;
        }

        public Employee(string name, string surname, string patronymic, DateTime dateOfBirth, string phoneNumber, string email) : this()
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void InputInfo()
        {
            Console.WriteLine("Введіть Ім'я: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введіть Прізвище: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Введіть По батькові: ");
            Patronymic = Console.ReadLine();
            Console.WriteLine("Введіть дату народження: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Введіть номер телефону: +");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введіть email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Введіть посаду: ");
            Position = Console.ReadLine();
            Console.WriteLine("Введіть опис обов'язків: ");
            JobDescription = Console.ReadLine();
            Console.WriteLine("Введіть значення зарплати: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Інформація про співробітника:");
            Console.WriteLine($"ПІБ: {Surname} {Name} {Patronymic}");
            if (DateOfBirth != null && DateOfBirth != DateTime.MinValue)
            {
                Console.WriteLine($"Дата народження: {DateOfBirth.ToShortDateString()}");
            }
            if (PhoneNumber != null)
                Console.WriteLine($"Номер телефону: {PhoneNumber}");
            if (Email != null)
                Console.WriteLine($"Email: {Email}");
            if (Position != null)
            {
                Console.WriteLine($"Посада: {Position}");
            }
            if (JobDescription != null)
                Console.WriteLine($"Опис обов'язків: {JobDescription}");
            if (Salary != 0)
                Console.WriteLine($"Зарплата: {Salary}");
        }

        public static int operator +(Employee employee, int value)
        {
            employee.Salary += value;
            return employee.Salary;
        }
        public static int operator -(Employee employee, int value)
        {
            employee.Salary -= value;
            return employee.Salary;
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Salary == employee2.Salary)
                return true;
            else
                return false;
            
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee otherEmployee = (Employee)obj;
            return this.Salary == otherEmployee.Salary;
        }
    }
    
}
