using System;

namespace BalagwisJohnDenverNestedIf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Comparison();
        }

        private static void Comparison()
        {
            Console.WriteLine("\n\t=========================================");
            Console.WriteLine("\tDEMONSTRATION OF NESTED IF ELSE CONSTRUCT");
            Console.WriteLine("\t=========================================\n");
            Console.Write("\tENTER THE FIRST NUMBER : ");

            int first = int.Parse(Console.ReadLine());

            Console.Write("\tENTER THE SECOND NUMBER : ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("\tENTER THE THIRD NUMBER : ");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t=========================================\n");
            Console.WriteLine("\tTHE FIRST NUMBER IS : " + first);
            Console.WriteLine("\tTHE SECOND NUMBER IS : " + second);
            Console.WriteLine("\tTHE THIRD NUMBER IS : " + third);
            Console.WriteLine("\n\t=========================================");

            if (first == second && second == third && third == first)
            {
                Console.WriteLine("\n\tTHE THREE NUMBERS ARE EQUAL");
            }
            else if (first == second || second == third || third == first)
            {
                Console.WriteLine("\n\tTHE TWO NUMBERS ARE EQUAL");
            }

            else
            {
                if (first > second && first > third)
                {
                    Console.WriteLine("\tTHE FIRST IS THE HIGHEST NUMBER");
                }
                else if (second > first && second > third)
                {
                    Console.WriteLine("\tTHE SECOND IS THE HIGHEST NUMBER");
                }
                else if (third > first && third > second)
                {
                    Console.WriteLine("\tTHE THIRD IS THE HIGHEST NUMBER");
                }
            }

            Console.Write("\n\tWANT TO ENTER AGAIN [Y/N]? ");
            string option = Console.ReadLine();

            if (option == "y" || option == "Y")
            {
                Comparison();
            }
            else
            {
                Console.WriteLine("\tTHANK YOU FOR USING THIS PROGRAM, BYE...");
                Console.WriteLine("\n\t=========================================");
                Console.ReadLine();
            }
        }
    }
}