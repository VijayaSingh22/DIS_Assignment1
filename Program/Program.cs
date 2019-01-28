using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            //print prime number
            int a = 5, b = 15;
            printPrimeNumbers(a, b);
            Console.ReadKey();

            //compute the series
            int n1 = 5;
            double r1 = Math.Round(getSeriesResult(n1),3);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadKey();

            //decimal to binary
            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey();

            //binary to decimal
            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey();

            //to print trianle pattern
            int n4 = 5;
            printTriangle(n4);
            Console.ReadKey();

            //compute frequency
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();

        }
        //prime number function
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                bool isPrime = true;
                // conditional flow to run for the values from x and till y
                for (int i = x; i <= y; i++)
                {
                    for (int j = 2; j <= x; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;     // to break the loop if value is not prime and start checking for the next one
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine("Prime:" + i); // print values if it is prime
                    }
                    isPrime = true;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        // compute series result function
        public static double getSeriesResult(int n)
        {
            try
            {
                double seriesResult = 0;
                for (double i = 1; i < n; i++)
                {
                    if (i % 2 == 0)                             // To check if the term is evrn or odd
                    {
                        seriesResult += -((calFactorial(i)) / (i + 1));  // It will execute for even terms and will call function calFactorial to calculate factorial

                    }
                    else
                    {
                        seriesResult += ((calFactorial(i)) / (i + 1));  //It will execute for odd terms
                    }
                }
                return seriesResult;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        //compute factorial function
        public static double calFactorial(double number)
        {
            double fact = number;
            for (double i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        //decimal to binary function
        public static long decimalToBinary(long n)
        {
            try
            {
                long finalValue = 0;
                long binaryValue = 0;
                long decimalValue = n;
                while (n > 0)
                {
                    long remainder = n % 2; // to take the remainder for 
                    long dividend = n / 2;
                    n = dividend;
                    finalValue = long.Parse(binaryValue.ToString() + remainder.ToString());
                    binaryValue = finalValue;
                }
                return finalValue;
            }
            
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            return 0;
        }

        //binary to decimal function
        public static long binaryToDecimal(long n)
        {
            try
            {
                long decimalValue = 0;
                long binaryValue = n;
                long right = 0;
                int place = 0;
                while (n!=0)
                {
                    right = n % 10;
                    n = n / 10;
                    decimalValue += right * nPowerOfTwo(place);
                    place = place + 1;
                }
                return decimalValue;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return 0;
        }

        //compute n power of 2
        public static long nPowerOfTwo(int n)
        {
            long final = 1;
            if(n>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    final = final * 2;
                }
            }
            return final;
        }

        //to print traingle pattern
        public static void printTriangle(int n)
        {
            try
            {
                for (int loop = 1; loop <= n; loop++) //to iterate for n number of loops
                {
                    for (int space = n - loop; space >= 0; space--)//to give space after pattern
                    {
                        Console.Write(" ");
                    }
                    for (int asterisk = loop; asterisk >= 1; asterisk--) //to print *
                    {
                        Console.Write("*" + "");
                    }
                    for (int j = 2; j <= loop; j++) //for printing *
                    {
                        Console.Write("*" + "");
                    }
                    Console.WriteLine();

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            try
            {
                int[] arr = new int[100];
                arr = a;
                for(int i=0; i<a.Length; i++)
                {
                    if(!(dictionary.ContainsKey(a[i])))
                        {
                        dictionary.Add(a[i], 1);
                    }
                    else
                    {
                        dictionary[a[i]] = dictionary[a[i]] + 1;
                    }
                }
                Console.WriteLine("Number  Frequency");
                for(int i = 0; i < dictionary.Count; i++)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", dictionary.Keys.ElementAt(i), dictionary[dictionary.Keys.ElementAt(i)]);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }
}
