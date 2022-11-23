using static FunctionalProgram.FactorNum;

namespace FunctionalProgram

{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect program\n 1.FlipCoin\n 2.EvenOdd \n 3.Factors \n 4.FindLargest");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FunctinalProgramFlip flipCoin = new FunctinalProgramFlip();
                        flipCoin.FlipCoin();
                        break;

                    case 2:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.Findnum();
                        break;
                    case 3:
                        FactorNum fact = new FactorNum();
                        fact.factors();
                        break;
                    case 4:
                        Find find = new Find();
                        find.FindLargestNumber();
                        break;
                       

                }
            }
        }
    }
}
