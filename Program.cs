using System;

namespace CSharpPractice
{
    class Program
    {


        static void Main(string[] args)
        {
            Average();
        }

        public static void Average()
        {
            string input = "0";
            int total = 0;
            int count = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                System.Console.WriteLine("Last number entered was: {0}", currentNumber);
                System.Console.WriteLine("Current count is: {0}", count);
                System.Console.WriteLine("Please enter -1 once you are ready to calculate the average.");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    System.Console.WriteLine("-------------------------------------------------------------");
                    //Calculate average
                    double average = (double)total / (double)count;
                    System.Console.WriteLine("The average of the students is: {0}", average);
                }

                if (int.TryParse(input, out currentNumber) && currentNumber > -1 && currentNumber < 21)
                {
                    total += currentNumber;

                }
                else

                        if (!(input.Equals("-1")))
                {
                    System.Console.WriteLine("Please enter a valid number between 0 and 20.");
                    continue;
                }
                count++;

            }

        }
    }


}
