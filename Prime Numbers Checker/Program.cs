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
                    return false;

                else
                {
                    if (PrimeNum == 2)
                        return true;
                    // Check Even Number 
                    if (PrimeNum % 2 == 0)
                       return false;
                    else
                    {
                        // Check Odd Numbers
                        //   *** n/i ***
                        // PrimeNum / 3 = R   -so-  PrimeNum / R = 3 
                        // if you checked a number you already checked the other
                        for (int i = 2; i < PrimeNum / i; i += 2)
                        {

                            // ignore Multiples   : Not completed yet 
                            if (i+1 > 13)
                            {
                                if ((i + 1) % 3 == 0 || (i + 1) % 5 == 0 || (i + 1) % 7 == 0 || (i + 1) % 11 == 0 || (i + 1) % 13 == 0)
                                {
                                    // Do Nothing :0  
                                }
                                else
                                {
                                    
                                    if (PrimeNum % (i + 1) == 0)
                                        return false;
                                }
                            }
                            else
                            {
                               
                                if (PrimeNum % (i + 1) == 0)
                                    return false;
                            }
                        }
                        return true;
                    }
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

}
