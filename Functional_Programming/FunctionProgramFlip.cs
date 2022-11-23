using System.Security.Cryptography.X509Certificates;

namespace FunctionalProgram
{
    internal class FunctinalProgramFlip
    {
        Random random = new Random();
        public double CoinToss()
        {
            double number = random.NextDouble();
            return number;
        }

        public void FlipCoin()
        {
            double count = 0, headCount = 0, tailCount = 0, coinFlip;
            Console.Write("Enter number of COIN flip for the toss : ");
            coinFlip = Convert.ToInt32(Console.ReadLine());
            while (coinFlip != count)
            {
                count++;
                double toss = CoinToss();
                if (toss < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }

            double he = (double)((headCount * 100) / coinFlip);
            double ta = (double)((tailCount * 100) / coinFlip);
            Console.WriteLine("Winning percentage of HEAD is : " + he);
            Console.WriteLine("Winning percentage of TAIL is : " + ta);

        }
    }
    public class EvenOdd
    {
        public void Findnum()
        {
            int num1, rem1;
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("\n");
            Console.Write("Enter No : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an Even No.\n", num1);
            else
                Console.WriteLine("{0} is an Odd No.\n", num1);
        }
    }
    public class FactorNum
    {
        int num;
        public void factors()
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if (num >= 2)
            {
                Console.WriteLine(num);
            }
        }
        public class Find
        {
            public void FindLargestNumber()
            {
                int num1, num2, num3;

                Console.Write("Find the largest of three numbers:");



                Console.Write("\nInput the 1st number :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the  2nd number :");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd  number :");
                num3 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.Write("The 1st Number is the greatest among three");
                    }
                    else
                    {
                        Console.Write("\nThe 3rd Number is the greatest among three");
                    }
                }
                else if (num2 > num3)
                    Console.Write("The 2nd Number is the greatest among three");
                else
                    Console.Write("The 3rd Number is the greatest among three");
            }
        }

        public class LeapYear
        {
            public void Year()
            {
                {
                    Console.WriteLine("Enter Year: ");
                    int Year = int.Parse(Console.ReadLine());

                    if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    {

                        Console.WriteLine("{0} is Leap Year.", Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} Is not a leap year.", Year);
                    }
                    Console.ReadLine();
                }
            }
            public class NPower
            {
                public void PowerOfTwo()
                {
                    Console.WriteLine("Enter as 2^Number:- ");
                    string NNumber = Console.ReadLine();
                    int number = Convert.ToInt32(NNumber);
                    int num = 1;
                    int i = 1;
                    int LimitPowerTwo = 31;
                    if (number > LimitPowerTwo)
                    {
                        Console.WriteLine($"You Enter {number}  of 2^ exceeds the value limit 31  ");
                    }
                    else
                    {
                        for (i = 1; i <= number; i++) //to Check a number 
                        {
                            num = (num * 2); // multiply number by 2
                            Console.WriteLine(num);
                        }
                    }
                }
                  internal class SwapNumber
                  {
                    public void SwapTwoNumbers()
                    {
                        Console.WriteLine("Enter First Number : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number : ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        a = a + b;
                        b = a - b;
                        a = a - b;

                        Console.WriteLine("After Swap" + "\n" + "First Number Is " + a + "\n" + "Second Number Is " + b);
                    }
                }
            }
        }
    }
}



    