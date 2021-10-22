using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimest arvu:");
            int UserNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Palun vali tehe (sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(UserNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(UserNumberOne, userNumberTwo);
                    break;
                case '-':
                    TakeAwayTwoNumbers(UserNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultipyTwoNumbers(UserNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("kena päeva!");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        private static void MultipyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        private static void TakeAwayTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }

}
