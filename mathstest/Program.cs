using System;

namespace mathstest
{
    class Program
    {
        public static void Main(string[] args)
        {
            int mark = 0;

            Console.WriteLine("5 * 4 =");
            string Q1 = Console.ReadLine();
            if (Q1 == "20")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("7 * 8 =");
            string Q2 = Console.ReadLine();
            if (Q2 == "56")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("9 * 6 =");
            string Q3 = Console.ReadLine();
            if (Q3 == "54")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("10 * 10 =");
            string Q4 = Console.ReadLine();
            if (Q4 == "100")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("4 * 12 =");
            string Q5 = Console.ReadLine();
            if (Q5 == "48")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("0 * 2 =");
            string Q6 = Console.ReadLine();
            if (Q6 == "0")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("17 * 11 =");
            string Q7 = Console.ReadLine();
            if (Q7 == "187")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("28 * 33 =");
            string Q8 = Console.ReadLine();
            if (Q8 == "924")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("66 * 72 =");
            string Q9 = Console.ReadLine();
            if (Q9 == "4752")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine("117 * 987 =");
            string Q10 = Console.ReadLine();
            if (Q10 == "115479")
            {
                Console.WriteLine("Well Done!");
                mark++;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.WriteLine($"You got a score of {mark} out of 10");
        }
    }
}
