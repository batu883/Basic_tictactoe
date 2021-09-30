using System;
namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            string user1;
            string user2;
            int choise1;
            int choise2;
            int win1 = 0;
            int win2 = 0;
            int draw = 0;
            int limit;
            Console.WriteLine("Oyuncu 1 isim giriniz: ");
            user1 = Console.ReadLine();
            Console.WriteLine("Oyuncu 2 isim giriniz:  ");
            user2 = Console.ReadLine();
            Console.WriteLine("How many games do you want to play?");
            limit= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n1 for rock \n2 for paper\n3 for scissors\n");
            for ( int i = 0; i < limit; i++)
            {
                Console.WriteLine(user1 + "  please choose  ");
                choise1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(user2 + "  please choose  ");
                choise2 = Convert.ToInt16(Console.ReadLine());
                if (choise1 == 1 && choise2 == 1 || choise1 == 2 && choise2 == 2 || choise1 == 3 && choise2 == 3)
                {
                    draw++;
                    Console.WriteLine("It's DRAW! \n");
                }
                else if (choise1 == 2 && choise2 == 1 || choise1 == 3 && choise2 == 2 || choise1 == 1 && choise2 == 3)
                {
                    win1++;
                    Console.WriteLine(user1 + "  WINS \n ");
                }
                else if (choise1 == 1 && choise2 == 2 || choise1 == 2 && choise2 == 3 || choise1 == 3 && choise2 == 1)
                {
                    win2++;
                    Console.WriteLine(user2 + "  WINS \n");
                }
            }
            Console.WriteLine("ScoreList:  \n");
            Console.WriteLine(user1 + " wins " + win1 + " of games in total " + limit + " games ");
            Console.WriteLine(user2 + " wins " + win2 + " of games in total " + limit + " games ");
            Console.WriteLine("Draw:  "+ draw+" of games in total  "+limit+" games");
        }
    }
}
