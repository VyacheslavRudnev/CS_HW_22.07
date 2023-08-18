using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Models
{
    public class Shop
    {
        private string _shopName;
        private string _shopAddress;
        private string _shopDescription;
        private string _shopPhoneNumber;
        private string _shopEmailAddress;
        private int _shopSquare;

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }
        public string ShopAddress
        {
            get { return _shopAddress; }
            set { _shopAddress = value; }
        }
        public string ShopDescription
        {
            get { return _shopDescription; }
            set { _shopDescription = value; }
        }
        public string ShopPhoneNumber
        {
            get { return _shopPhoneNumber; }
            set
            {
                if (value.Length != 12)
                {
                    throw new ArgumentException("Номер телефону повинен містити 12 символів");
                }
                else
                {
                    long number = Convert.ToInt64(value);
                    _shopPhoneNumber = number.ToString("+## (###) ###-##-##");
                }
            }
        }
        public string ShopEmailAddress
        {
            get { return _shopEmailAddress; }
            set { _shopEmailAddress = value; }
        }
        public int ShopSquare
        {
            get { return _shopSquare; }
            set { _shopSquare = value; }
        }
        public Shop() { }
        public Shop(string shopName, int shopSquare)
        {
            ShopName = shopName;
            ShopSquare = shopSquare;
        }

        public Shop(string shopName, string shopAddress, string shopDescription, string shopPhoneNumber, string shopEmailAddress)
        {
            ShopName = shopName;
            ShopAddress = shopAddress;
            ShopDescription = shopDescription;
            ShopPhoneNumber = shopPhoneNumber;
            ShopEmailAddress = shopEmailAddress;
        }
        public override string ToString()
        {
            return $"Магазин: {ShopName}, площа: {ShopSquare}";
                   //$"Адреса магазину: {ShopAddress}\n" +
                   //$"Опис магазину: {ShopDescription}\n" +
                   //$"Телефонний номер: {ShopPhoneNumber}\n" +
                   //$"email: {ShopEmailAddress}\n";
                   
        }
        public void InputShop()
        {
            Console.WriteLine("Введіть назву магазину: ");
            ShopName = Console.ReadLine();
            Console.WriteLine("Введіть адресу магазину: ");
            ShopAddress = Console.ReadLine();
            Console.WriteLine("Введіть опис магазину: ");
            ShopDescription = Console.ReadLine();
            Console.WriteLine("Введіть номер телефону магазину: + ");
            ShopPhoneNumber = Console.ReadLine();
            Console.WriteLine("Введіть email магазину: ");
            ShopEmailAddress = Console.ReadLine();
        }
        public void PrintShop()
        {
            Console.WriteLine($"\nІнформація про магазин:");
            Console.WriteLine($"Назва магазину: {ShopName}");
            if (ShopAddress != null)
            {
                Console.WriteLine($"Адреса магазину: {ShopAddress}");
            }
            if (ShopDescription != null)
            {
                Console.WriteLine($"Опис магазину: {ShopDescription}");
            }
            if (ShopPhoneNumber != null)
            {
                Console.WriteLine($"Номер телефону магазину: {ShopPhoneNumber}");
            }
            if (ShopEmailAddress != null)
            {
                Console.WriteLine($"Email магазину: {ShopEmailAddress}");
            }
            if (ShopSquare != 0)
            {
                Console.WriteLine($"Площа магазину: {ShopSquare}");
            }
        }

        public static Shop operator +(Shop shop, int value)
        {
            shop.ShopSquare += value;
            return shop;
        }

        public static Shop operator -(Shop shop, int value)
        {
            shop.ShopSquare -= value;
            return shop;
        }

        public static bool operator ==(Shop shop_1, Shop shop_2)
        {
            if (shop_1.ShopSquare == shop_2.ShopSquare)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Shop shop_1, Shop shop_2)
        {
            if (shop_1.ShopSquare != shop_2.ShopSquare)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Shop shop_1, Shop shop_2)
        {
            return shop_1.ShopSquare > shop_2.ShopSquare;
        }
        public static bool operator <(Shop shop_1, Shop shop_2)
        {
            return shop_1.ShopSquare < shop_2.ShopSquare;
        }
        public override bool Equals(object obj)
        {
            if (obj is Shop)
            {
                Shop shop = (Shop)obj;
                return shop.ShopSquare == this.ShopSquare;
            }
            return false;
        }



    }
    






}
