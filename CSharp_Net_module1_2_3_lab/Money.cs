using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration enumeration, values UAH, USD, EU
    enum CurrencyTypes
    {
        UAH, USD, EU
    }

    class Money
    {

        // 2) declare 2 properties Amount, CurrencyType
        public int Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }


        // 3) declare parameter constructor for properties initialization
        public Money(int Amount = 0, CurrencyTypes CurrencyType = CurrencyTypes.UAH)
        {
            this.Amount = Amount;
            this.CurrencyType = CurrencyType;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money amount1, Money amount2)
        {
            if (amount1.CurrencyType == amount2.CurrencyType)
                return new Money { Amount = amount1.Amount + amount2.Amount };
            else
                return new Money { Amount = 0 };

        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money amount)
        {
            amount.Amount--;
            return amount;  
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        int x = 3;
        public static Money operator *(Money amount, int x)
        {
            return new Money { Amount = amount.Amount * 3 };
        }
        // 7) declare overloading of operator > and < 2 objects of Money
        public static bool operator <(Money amount1, Money amount2)
        {
            if (amount1.CurrencyType == amount2.CurrencyType && amount1.Amount < amount1.Amount)
                return true;
            else
                return false;
        }
        public static bool operator >(Money amount1, Money amount2)
        {
            if (amount1.CurrencyType == amount2.CurrencyType && amount1.Amount > amount1.Amount)
                return true;
            else
                return false;
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object
        //public static Money operator true(Money CurrencyType)
        //{
          
        //}
        //public static bool operator false(Money CurrencyType)
        //{
          
        //}



        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa



        //public int ConverterToUAH(CurrencyTypes value)
        //{

        //  if (value == CurrencyTypes.USD)
        //        return Amount = value / 30;

        //}  

    }
}
