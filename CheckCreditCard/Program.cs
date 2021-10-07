using System;

namespace CheckCreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to use REGEX method please enter '1' , if you dont want to use REGEX please enter '2'");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                CheckCreditCardNumberwithREGEX checkCreditCardNumberwithREGEX = new CheckCreditCardNumberwithREGEX();

            }
            else if (choice == 2)
            {
                CheckCreditCardNumber checkCreditCardNumber = new CheckCreditCardNumber();

            }
            else
            {
                Console.WriteLine("You enter invalid number");
            }
        }
    }
}


        