using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereeib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu voidab arvuti
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            {
                int i = 0;
                while (i < 3)
                {
                    int cpuNumber = rnd.Next(1, 11);
                    Console.WriteLine("Arva ära number 1 kuni 10:");

                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    if(userNumber == cpuNumber)
                    {
                        Console.WriteLine("Palju õnne! See on õige number!");
                        break;
                    }
                    else
                    {
                        i++;
                        Console.WriteLine($"Vale number. Palun proovi uuest. Alles on veel {3 - i} katset. ");
                    }
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
