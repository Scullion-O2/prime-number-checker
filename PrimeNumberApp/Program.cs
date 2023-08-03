using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace PrimeNumberApp
{
    class PrimeNumberProgram
    {
        static void Main(string[] args)
        {

            int counter = 0;

            while (counter < 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEnter the number you want to check: (Type 'q' to quit)");
                string userPrimeNumber = "";

                userPrimeNumber = Console.ReadLine();

                if (userPrimeNumber.Equals("q"))
                {
                    Console.WriteLine("\nEnding program...");
                    break;
                }
                else
                {
                    long userPrimeNumberConv;

                    try
                    {
                        userPrimeNumberConv = Convert.ToInt64(userPrimeNumber);
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid input, make sure to enter numbers or 'q' only!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n----- DEFAULTING INPUT TO 0 -----\n");

                        userPrimeNumberConv = 0;
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid input, number entered was either too low or too large!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n----- DEFAULTING INPUT TO 0 -----\n");

                        userPrimeNumberConv = 0;
                    }
                    long divisiors = 0;
                    long i = 1;



                    for (i = 1; i <= userPrimeNumberConv; i++)
                    {
                        float percentage = (float)i / (float)userPrimeNumberConv * 100;


                        if (userPrimeNumberConv % i == 0)
                        {
                            divisiors++;
                        }

                        /**Shows user the progress of the calculation (WILL SLOW THE PROGRESS SIGNIFICANTLY)
                        if ((int)percentage % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\r{0}%         ", percentage);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\r{0}%         ", percentage);
                        }

                        **/
                    }

                    if (divisiors == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n----------------------------------------");
                        Console.WriteLine("The number you entered is a prime number!");
                        Console.WriteLine("----------------------------------------");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n----------------------------------------");
                        Console.WriteLine("The number you entered is not a prime number!");
                        Console.WriteLine("----------------------------------------");
                    }
                }
            }
        }
    }
}