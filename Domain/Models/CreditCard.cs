using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
//В одному з попередніх практичних завдань ви створю-
//вали клас «Кредитна картка».
//Додайте до вже створеного
//класу інформацію про суму грошей на картці.Виконай -
//те перевантаження + (для збільшення суми грошей на
//вказану кількість), – (для зменшення суми грошей на
//вказану кількість), == (перевірка на рівність CVC коду),
//< і > (перевірка на меншу чи більшу кількість суми гро -
//шей), != і Equals.Використовуйте механізм властивостей
//полів класу.
    public class CreditCard
    {
        private string _cardNumber;
        private string _cvc;
        private string _expirationDate;
        private double _balance;
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                string cardNumberWithoutSpaces = value.Replace(" ", "");
                if (cardNumberWithoutSpaces.Length == 16)
                {
                    _cardNumber = value;
                }
                else
                {
                    throw new Exception("Номер картки повинен містити 16 символів");
                }
            }
        }
        public string CVC
        {
            get { return _cvc; }
            set
            {
                if (value.Length == 3)
                {
                    _cvc = value;
                }
                else
                {
                    throw new Exception("CVC повинен містити 3 символи");
                }
            }
        }
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                if (value.Length == 5)
                {
                    _expirationDate = value;
                }
                else
                {
                    throw new Exception("Дата повинна містити 5 символів");
                }
            }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    throw new Exception("Баланс не може бути від'ємним");
                }
            }
        }

        public CreditCard() { }

        public CreditCard(string number, string cvc, double balance)
        {
            CardNumber = number;
            CVC = cvc;
            Balance = balance;
        }
        public CreditCard(string number, string cvc, string expirationDate, double balance)
        {
            CardNumber = number;
            CVC = cvc;
            ExpirationDate = expirationDate;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"Картка №: {CardNumber}, " +
                   $"CVC код: {CVC}, " +
                   $"Поточний баланс: {Balance:f2}";
        }
        public static CreditCard operator +(CreditCard card, double value)
        {
            card.Balance += value;
            return card;
        }

        public static CreditCard operator -(CreditCard card, double value)
        {
            card.Balance -= value;
            return card;
        }

        public static bool operator ==(CreditCard card_1, CreditCard card_2)
        {
            if (card_1.CVC == card_2.CVC)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(CreditCard card_1, CreditCard card_2)
        {
            if (card_1.CVC != card_2.CVC)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(CreditCard card_1, CreditCard card_2)
        {
            return card_1.Balance > card_2.Balance;
        }
        public static bool operator <(CreditCard card_1, CreditCard card_2)
        {
            return card_1.Balance < card_2.Balance;
        }
        public override bool Equals(object obj)
        {
            if (obj is CreditCard)
            {
                CreditCard card = (CreditCard)obj;
                return card.CVC == CVC;
            }
            return false;
        }
        //public override bool Equals(object obj)
        //{
        //    if (obj is CreditCard)
        //    {
        //        CreditCard card = (CreditCard)obj;
        //        return card.Balance == Balance;
        //    }
        //    return false;
        //}

    }
}
