using System;

namespace CheckCreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Credit Card Number please");
            string creditCardNumber = Console.ReadLine();

            CheckCreditCardNumber(creditCardNumber);

            Console.WriteLine("If you want to do another check please enter '1', if you don't please enter : '0'");
            int choice = Convert.ToInt32(Console.ReadLine()) ;

            while (choice == 1)
            {
                Console.WriteLine("Enter the Credit Card Number please");
                creditCardNumber = Console.ReadLine();
                CheckCreditCardNumber(creditCardNumber);
                Console.WriteLine("If you want to do another check please enter '1', if you don't please enter : '0'");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
        private static void CheckCreditCardNumber(string creditCardNumber)
        {
            
            if (creditCardNumber.Length > 16 || creditCardNumber.Length < 13)
            {
                Console.WriteLine("You enter invalid credit card number, please try again.");
                creditCardNumber = Console.ReadLine();
                CheckCreditCardNumber(creditCardNumber);

            }
            else if (creditCardNumber[0] == 52)
            {
                Console.WriteLine("VISA");
            }
            else if ((creditCardNumber[0] == 53 || creditCardNumber[0] == 50) && creditCardNumber.Length == 16)
            {
                Console.WriteLine("MASTERCARD");
            }
            else if (creditCardNumber[0] == 51 && creditCardNumber.Length == 15 && (creditCardNumber[1]== 52 || creditCardNumber[1] == 55))
            {
                Console.WriteLine("AMERICAN EXPRESS");
            }
            else if (creditCardNumber[0] == 51 && creditCardNumber.Length == 14 && (creditCardNumber[1] == 48 || creditCardNumber[1] == 54 || creditCardNumber[1] == 56))
            {
                Console.WriteLine("DINERS CLUB");
            }
            else if (creditCardNumber[0] == 51 && creditCardNumber.Length == 16)
            {
                Console.WriteLine("JCB");
            }
            else if (creditCardNumber[0] == 54 )
            {
                Console.WriteLine("DISCOVER");
            }
            else
            {
                Console.WriteLine("Your credit card number does not belong any company.");
            }
        }
    }
}
