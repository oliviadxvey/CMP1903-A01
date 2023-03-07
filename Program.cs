using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fields for user inputted values

            string programType;
            int userShuffle;
            int userCards;
            int amount;
            List<Card> dealtCards = new List<Card>();

            Console.WriteLine("Would you like to run the test program or final program?");
            Console.Write("Please enter T for test, F for final: ");

            programType = Console.ReadLine();

            if (programType != "T" && programType != "F") {
                throw new FormatException("Value must be single character, either T or F.");
            }

            else {
                Console.WriteLine(" ");
                if (programType == "T") {
                    Testing.test();
                }

                else {
                    Console.WriteLine("Which shuffle you would like to use?");
                    Console.Write("Please enter 1 for Fisher-Yates Shuffle, 2 for Riffle Shuffle, 3 for No Shuffle: ");

                    try
                    {
                        userShuffle = Convert.ToInt32(Console.ReadLine());

                        if (userShuffle > 3 || userShuffle < 1) {
                            throw new ArgumentOutOfRangeException("Number must be either 1, 2, or 3.");
                        }

                        else {
                            Pack.shuffleCardPack(userShuffle);
                        }
                    }

                    catch (FormatException)
                    {
                        throw new FormatException("Value must be a number with at least one digit.");
                    }

                    Console.WriteLine("\nWould you like to draw one card or a set of cards?");
                    Console.Write("Please enter 1 for one, 2 for set: ");

                    try
                    {
                        userCards = Convert.ToInt32(Console.ReadLine());

                        if (userCards > 2 || userCards < 1) {
                            throw new ArgumentOutOfRangeException("Number must be either 1 or 2.");
                        }

                        else {
                            if (userCards == 1) {
                                Console.WriteLine("\nYour card: " + Pack.deal().returnCard());
                            }

                            else {
                                Console.Write("How many cards would you like to deal? ");

                                try
                                {
                                    amount = Convert.ToInt32(Console.ReadLine());

                                    if (amount > 52 || amount < 0) {
                                        throw new ArgumentOutOfRangeException("Number must be greater than 0 but less than 53.");
                                    }

                                    dealtCards = Pack.dealCard(amount);

                                    Console.WriteLine("\nYour cards: ");

                                    foreach (Card c in dealtCards) {
                                        Console.WriteLine(c.returnCard());
                                    }
                                }

                                catch (FormatException)
                                {
                                    throw new FormatException("Value must be a number with at least one digit.");
                                }
                            }
                        }
                    }

                    catch (FormatException)
                    {
                        throw new FormatException("Value must be a number with at least one digit.");
                    }
                }
            }
        }
    }
}