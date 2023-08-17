using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class City
    {
        //назву міста, назву країни, кількість жителів у місті,
        //телефонний код міста, назву районів міста.
        private string _cityName;
        private string _countryName;
        private int _population;
        private string _phoneCode;
        private string[] _districts;

        public string CityName
        {
            get { return (_cityName is null) ? throw new ArgumentNullException("CityName is null") : _cityName; }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("CityName is null");
                else if (value.Length < 2)
                    throw new ArgumentException("CityName must be at least 2 characters!");
                else
                    _cityName = value;
            }
        }
        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }
        public string PhoneCode
        {
            get { return _phoneCode; }
            set { _phoneCode = value; }
        }
        public string[] Districts
        {
            get { return _districts; }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("Districts is null");
                else
                    _districts = value;
            }
        }
            
        public City() { }

        public City(string _cityName):this()
        {
            this._cityName = _cityName;
        }
        public City(string _cityName, int _population) : this()
        {
            this._cityName = _cityName;
            this._population = _population;
        }
        public City(string _cityName, string _countryName, int _population, string _phoneCode) : this()
        {
            this._cityName = _cityName;
            this._countryName = _countryName;
            this._population = _population;
            this._phoneCode = _phoneCode;
        }
        public City(string _cityName, string _countryName, int _population, string _phoneCode, string[] _districts)
        {
            this._cityName = _cityName;
            this._countryName = _countryName;
            this._population = _population;
            this._phoneCode = _phoneCode;
            this._districts = _districts;
        }
        
        public override string ToString()
        {
            return $"CityName: {_cityName}\n" +
                   $"CountryName: {_countryName}\n" +
                   $"Population:{_population}\n"+
                   $"PhoneCode: {_phoneCode}\n" +
                   $"Districts: {_districts}\n";
        }
        public void InputInfo()
        {
            Console.WriteLine("Введіть назву міста: ");
            _cityName = Console.ReadLine();
            Console.WriteLine("Введіть назву країни: ");
            _countryName = Console.ReadLine();
            Console.WriteLine("Введіть кількість жителів у місті: ");
            _population = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть телефонний код міста: ");
            _phoneCode = Console.ReadLine();
            Console.WriteLine("Введіть назву районів міста через пробіл: ");
            _districts = Console.ReadLine().Split(' '); 
        }
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Назва міста: {_cityName}");
            Console.WriteLine($"Назва країни: {_countryName}");
            Console.WriteLine($"Кількість жителів у місті: {_population}");
            Console.WriteLine($"Телефонний код міста: {_phoneCode}");
            Console.WriteLine($"Назви районів міста: ");
            for (int i = 0; i < _districts.Length; i++)
            {
                Console.WriteLine($"\t{i + 1}.{_districts[i]}");
            }
            
        }
        public static int operator +(City city, int value)
        {
            city._population += value;
            return city._population;
        }
        public static int operator -(City city, int value)
        {
            city._population -= value;
            return city._population;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1._population > city2._population;
        }
        public static bool operator <(City city1, City city2)
        {
            return city1._population < city2._population;
        }
        public static bool operator ==(City city1, City city2)
        {
            return city1._population == city2._population;
        }
        public static bool operator !=(City city1, City city2)
        {
            return city1._population != city2._population;
        }
        public override bool Equals(object obj)
        {
            if (obj is City)
            {
                City city = (City)obj;
                return this._population == city._population;
            }
            else
                return false;
        }

    }
}
