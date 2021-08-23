using System;

namespace Prime_Numbers_Checker
{
    class Program
    {
        static public class Prime
        {
           static public  bool  check(int PrimeNum)
           {
                // Check From 1 to -  
                if (PrimeNum <= 1)
                {
                    Console.WriteLine("Steps Counter : 1 ");
                    return false;
                }

                if (PrimeNum == 2 || PrimeNum == 3 || PrimeNum == 5)
                {
                    Console.WriteLine("Steps Counter : 2 ");
                    return true;
                }
                // Check Even Number 
                if (PrimeNum % 2 == 0 || PrimeNum % 5 == 0)
                {
                    Console.WriteLine("Steps Counter : 3 ");
                    return false;
                }
                        // Check Odd Numbers
                        //   *** n/i ***
                        // PrimeNum / 3 = R   -so-  PrimeNum / R = 3 
                        // if you checked a number you already checked the other side
                int counter = 3;
                for (int i = 2; i < PrimeNum / i; i += 2)
                {
                    counter++;
                    if (PrimeNum % (i + 1) == 0)
                    {
                        Console.WriteLine("Steps Counter : " + counter);
                        return false;
                    }
                    // ignore Multiples   : Not completed yet 
                    if ((i + 3) % 5 == 0)
                        i += 2;
                }
                Console.WriteLine("Steps Counter : " + counter);
                return true;
           }
        }
            static void Main(string[] args)
            { 
                try
                {
                    int p = 0;
                    Console.WriteLine("\n\t\t  Prime Numbers Checker");
                    Console.WriteLine("\t\t=========================");
                    while (true)
                    {
                        Console.Write("Enter the number : ");
                        p = int.Parse(Console.ReadLine());
                        if (Prime.check(p))
                            Console.WriteLine("Prime Number\n\n");
                        else
                        {
                            Console.WriteLine("Not a Prime Number\n\n");
                        }
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

            }
        }
    }


