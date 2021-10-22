using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbri 1-3
            //kui kasutaja sisestab 1, siis kuvatakse eesnime tagurpidi
            //kui kasutaja sisestab 2, siis kuvatakse eesnime esimest tähte
            //kui kasutaja alib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta enda eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali number 1, 2 või 3");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    GetUserNameData1(userName);
                    break;
                case '2':
                    GetUserNameData2(userName);
                    break;
                case '3':
                    GetUserNameData3(userName);
                    break;

            }
        }

        public static void GetUserNameData1 (string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--) 
            {
                Console.Write(userInput[i]);
            }
        }

        public static void GetUserNameData2 (string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void GetUserNameData3 (string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk");
        }

    }
}
