using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program 
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money money1 = new Money();
            Money money2 = new Money();

           
            // 11) do operations


            // add 2 objects of Money
           Money money3 = money1 + money2;
            // add 1st object of Money and double


            // decrease 2nd object of Money by 1 
            money2--;
            // increase 1st object of Money

            money1--;

            // compare 2 objects of Money
            bool money4 = money1 < money2;
            bool money5 = money1 > money2;


            // compare 2nd object of Money and string

            // check CurrencyType of every object
           

            // convert 1st object of Money to string

        }
    }
}
