using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        public List<Card> cardPack;
        public static List<Card> shuffledPack = new List<Card>(52);

        public Pack()
        {
            //Initialise the card pack here

            cardPack = new List<Card>(52);

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    cardPack.Add(new Card { val = j, suit = i });
                }
            }

            //13 values for each of the 4 suits, from ace to king
        }
        

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            Pack pack = new Pack();
            int packSize = pack.cardPack.Count;


            switch(typeOfShuffle)
            {
                case 1:
                //Fisher-Yates shuffle

                    for (int i = 0; i < packSize; i++) {

                        //Chooses random index number, adds element at that index to shuffled pack, removes copied element from original pack so it can't be picked out again

                        Random random = new Random();
                        int rand = random.Next(0, packSize - i);

                        Pack.shuffledPack.Add(pack.cardPack[rand]);
                        pack.cardPack.RemoveAt(rand);
                    }
                    break;

                case 2:
                //Riffle shuffle

                    Pack.shuffledPack.Clear();

                    List<Card> packFront = new List<Card>();
                    List<Card> packBack = new List<Card>();

                    //Splits list in half

                    for (int i = 0; i < packSize / 2; i++) {
                        packFront.Add(pack.cardPack[i]);
                    }

                    for (int i = packSize / 2; i < packSize; i++) {
                        packBack.Add(pack.cardPack[i]);
                    }

                    //Adds alternate cards from two halves to shuffled pack

                    for (int i = 0; i < packSize / 2; i++) {
                        Pack.shuffledPack.Add(packFront[i]);
                        Pack.shuffledPack.Add(packBack[i]);
                    }
                    break;

                case 3:
                //No shuffle, leaves pack as is

                    Pack.shuffledPack.Clear();
                    Pack.shuffledPack = pack.cardPack;
                    break;

                default:
                    break;
            }

            return true;
        }

        public static Card deal()
        {
            //Deals one card
            try
            {
                Card dealtCard = Pack.shuffledPack[0];
                return dealtCard;
            }

            catch (NullReferenceException)
            {
                throw new ArgumentOutOfRangeException("Null value detected. There may be an issue with the card pack.");
            }
        }

        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            try
            {
                List<Card> dealtCards = new List<Card>();

                for (int i = 0; i < amount; i++) {
                    dealtCards.Add(Pack.shuffledPack[i]);
                }

                return dealtCards;
            }

            catch (NullReferenceException)
            {
                throw new ArgumentOutOfRangeException("Null value detected. There may be an issue with the card pack.");
            }
        }
    }
}