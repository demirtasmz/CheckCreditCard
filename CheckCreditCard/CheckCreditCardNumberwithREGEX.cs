using System;
using System.Text.RegularExpressions;

namespace CheckCreditCard
{
    class CheckCreditCardNumberwithREGEX
    {
        public CheckCreditCardNumberwithREGEX()
        {
            Console.WriteLine("If you want to check credit card please enter '1', if you don't please enter : '0'");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice == 1)
            {
                Console.WriteLine("Enter the Credit Card Number please");
                string creditCardNumber = Console.ReadLine();
                CheckCreditCard(creditCardNumber);
                Console.WriteLine("If you want to do another check please enter '1', if you don't please enter : '0'");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void CheckCreditCard(string creditCardNumber)
        {
            string[] patternArray = new string[8];
            patternArray[0] = @"^4[0-9]{12}(?:[0-9]{3})$";
            patternArray[1] = @"^3[4|7][0-9]{13}$";
            patternArray[2] = @"^5[1-5][0-9]{14}$";
            patternArray[3] = @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$";
            patternArray[4] = @"^6(?:011|5[0-9]{2})[0-9]{12}$";
            patternArray[5] = @"^(?:2131|1800|35\d{3})\d{11}$";
            patternArray[6] = @"^(5018|5020|5038|5893|6304|6759|6761|6762|6763)[0-9]{8,15}$";
            patternArray[7] = @"^(9792[0-9]{12}|65[0-9]{14})$";



            for (int i = 0; i < patternArray.Length; i++)
            {
                Regex rg = new Regex(patternArray[i]);
                MatchCollection matchedPattern = rg.Matches(creditCardNumber);
                int index = i;
                if (matchedPattern.Count == 1)
                {
                    switch (index)
                    {
                        case 0: Console.WriteLine("VISA"); break;
                        case 1: Console.WriteLine("AMERICAN EXPRESS"); break;
                        case 2: Console.WriteLine("MASTERCARD"); break;
                        case 3: Console.WriteLine("DINERS CLUB"); break;
                        case 4: Console.WriteLine("DISCOVER"); break;
                        case 5: Console.WriteLine("JCB"); break;
                        case 6: Console.WriteLine("MAESTRO"); break;
                        case 7: Console.WriteLine("TROY"); break;
                        default: Console.WriteLine("Your credit card number does not belong any company."); break;
                    }
                }
            }
        }
    }
}

