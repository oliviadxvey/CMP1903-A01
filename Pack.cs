using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here

            Card card = new Card();

            pack = new List<Card>();
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            if (typeOfShuffle == 1) {

                // Fisher-Yates shuffle
                Random random = new Random();

                for (int i = pack.Count - 1; i > 0; i--) 
                {
                    int k = random.Next(i);
                    int temporary = pack[i];
                    pack[n] = pack[k];
                    pack[k] = temporary;
                }

            }
            else if (typeOfShuffle == 2) {

            }
            else if (typeOfShuffle == 3) {

            }

            return;
        }

        public static Card dealCard()
        {
            //Deals one card

            return;
        }

        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'

            return;
        }
    }

    class Testing 
    {
        public static int Test() 
        {
            Pack pack = new Pack();

            // Creates new Pack object

            for (int i = 0; i < 4; i++) {
                Pack.shuffleCardPack(i);
            }

            // Calls shuffleCardPack method 3 times, one for each shuffle type

            return;
        }
    }
}
