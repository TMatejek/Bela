using System;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int d = n.IndexOf(' ');
            int hands = int.Parse(n.Substring(0, d)) * 4;
            char suit = n[d + 1];
            int points = 0;

            char[] cards = { 'A', 'K', 'Q', 'J', 'T', '9', '8', '7' };
            int[] domValues = { 11, 4, 3, 20, 10, 14, 0, 0 };
            int[] notDomValues = { 11, 4, 3, 2, 10, 0, 0, 0 };

            for (int i  = 0; i < hands; i++)
            {
                string c = Console.ReadLine();
                char cCard = Convert.ToChar(c.Substring(0, 1));
                char cSuit = Convert.ToChar(c.Substring(1, 1));
                int y = 0;

                if (cSuit == suit)
                {
                    foreach (char x in cards)
                    {
                        if (cCard == x)
                        {
                            points += domValues[y];
                            break;
                        }

                        y++;
                    }
                }
                else
                {
                    foreach (char x in cards)
                    {
                        if (cCard == x)
                        {
                            points += notDomValues[y];
                            break;
                        }

                        y++;
                    }
                }
            }

            Console.WriteLine(points);

        }
    }
}
