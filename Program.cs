using System.ComponentModel.DataAnnotations;

namespace Assignment__two_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a console application to create a text file and save
            your basic details like name, age, address. Read the details
            from same file and print on console. 

            Design a tip calculator, enter the bill total, tip %, and display
            grand total after adding up
            */

            //Enter bill total
            //round to correct decimal point - Howto?
            Console.WriteLine("Welcome to the Tip calculator!");
            Console.WriteLine();
            Console.WriteLine("Please enter the total amount of your bill.");
            double Total = Convert.ToDouble(Console.ReadLine()); //words/errors?
            Console.WriteLine("");

            //error function
            //Console.WriteLine("Does not compute");

            //enter tip %
            //what if no state taxes?
            Console.WriteLine("Please enter the percentage you would like to tip. (Without percentage sign)");
            double Tip = Convert.ToDouble(Console.ReadLine());

            //doing math part
            double TipTotal = (Total * Tip) / 100;
            //##//
            //TotallyTotaled
            double BigTotal = Total + TipTotal;
            Console.WriteLine("");

            //round variables
            Total = Math.Round(Total, 2);
            BigTotal = Math.Round(BigTotal, 2);

            //display grand total
            //string console.writeLine with grand total
            //How to line up text below?
            Console.WriteLine($"Total Bill: ${Total}");
            Console.WriteLine($"Tip: {Tip}%"); //round percentages?
            Console.WriteLine($"Grand Total: ${BigTotal}");
            Console.WriteLine("");
            //Console.WriteLine("Continue? y/n");
            //loop? Do while
        }
    }
}
