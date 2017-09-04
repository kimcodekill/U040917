using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = new string[52];
            Random r = new Random();
            string card;
            int sum = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                card = string.Empty;
                switch (r.Next(1, 4))
                {
                    case 1:
                        card += 'H';
                        break;
                    case 2:
                        card += 'K';
                        break;
                    case 3:
                        card += 'R';
                        break;
                    case 4:
                        card += 'S';
                        break;
                }

                card += r.Next(1, 13);

                cards[i] = card;

                // Add looping statement checking if card already exists

            }

            foreach (string s in cards)
                Console.WriteLine(s);

            //Edit so if-statement only checks for y/n
            foreach (string s in cards)
            {
                Console.WriteLine("Vill du ha ett kort?");
                if (Console.ReadLine().ToLower() == "ja")
                {
                    Console.Write(s + ' ');
                    sum += Convert.ToInt32(s.Substring(1));
                    if (sum <= 21)
                        Console.WriteLine("(Poängsumma: " + sum + ')');
                    else
                    {
                        Console.WriteLine("Du förlorade! (Poängsumma: " + sum + ')');
                        break;
                    }
                }
                else
                    break;
            }

            if (sum == 21)
                Console.WriteLine("Grattis 21!");
        }
    }
}
