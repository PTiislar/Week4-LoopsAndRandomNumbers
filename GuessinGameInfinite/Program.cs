using System;

namespace GuessinGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereeib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit ühe korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while(true)
            {
                Console.WriteLine("Arva ära number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! See on õige number!");
                    break;
                }
                else
                {
                    Console.WriteLine("Arva uuesti!");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
