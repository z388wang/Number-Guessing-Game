using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main()
        {
            while (true)
            {
                Random number = new Random();
                int answer = number.Next(0, 100);


                int count = 1;
                Console.WriteLine("Number Guessing Game");
                Console.WriteLine("Please enter your number:");
                while (true)
                {
                    int guessing = Convert.ToInt32(Console.ReadLine());

                    if (guessing < answer)
                    {
                        Console.WriteLine("Low, please try again");
                        count++;
                        continue;
                    }
                    else if (guessing > answer)
                    {
                        Console.WriteLine("High, please try again");
                        count++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Correct! after you tried {0} times, let's play again!", count);
                        break;
                    }
                }

            }

            Console.ReadLine();

           
        }
    }
}
