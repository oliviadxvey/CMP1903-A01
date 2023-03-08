using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Additional testing class and method
//Used for testing all three types of shuffle, and process of dealing one or multiple cards from packs that have been shuffled

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public static void test()
        {
            Pack pack = new Pack();
            List<Card> testCards = new List<Card>();

            for (int i = 1; i < 4; i++)
            {
                Pack.shuffleCardPack(i);
                Console.WriteLine("1 card for shuffle type " + i + ": " + Pack.deal().returnCard() + "\n");

                testCards = Pack.dealCard(10);
                Console.WriteLine("10 cards for shuffle type " + i + ":");

                foreach (Card c in testCards)
                {
                    Console.WriteLine(c.returnCard());
                }

                Console.WriteLine(" ");
            }
        }
    }
}