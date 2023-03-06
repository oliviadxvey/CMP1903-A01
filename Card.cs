using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        //Base for the Card class.
        //The 'set' methods for these properties could have some validation

        //Value: numbers 1 - 13

        private int _value;
        public int val {

        get {
            if (_value >= 1 && _value <= 13) {
                return _value;
            }
            else {
                throw new ArgumentOutOfRangeException("Invalid number: Value is out of range.");
            }
        }

        set {
            _value = value;
        }
        }

        //Suit: numbers 1 - 4

        private int _suit;
        public int suit {

        get {
            if (_suit >= 1 && _suit <= 4) {
                return _suit;
            }
            else {
                throw new ArgumentOutOfRangeException("Invalid number: Value is out of range.");
            }
        }

        set {
            _suit = value;
        }
        }

        //Combining suit and value into single string, which will represent one card

        public string returnCard()
        {
            return this.val + " of " + this.suit;
        }
    }
}