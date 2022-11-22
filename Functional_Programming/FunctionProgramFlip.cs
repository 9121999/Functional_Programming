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
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Enter No : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an Even No.\n", num1);
            else
                Console.WriteLine("{0} is an Odd No.\n", num1);
        }
    }

}
    

 



