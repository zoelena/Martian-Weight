using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of the bill: ");
            string amountOfBill = Console.ReadLine();

            Console.Write("Please enter the amount tendered: ");
            string amountTendered = Console.ReadLine();

            decimal bill = decimal.Parse(amountOfBill);
            decimal tendered = decimal.Parse(amountTendered);

            if (tendered < bill)
            {
                Console.Write("You did not provide enough money.");
            }
            else
            {
                Console.Write($"The change required is: {tendered - bill}");
            }
        }
    }
}
