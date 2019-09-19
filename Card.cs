using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
using TexasHoldem.Properties;

namespace TexasHoldem
{
    public enum RANK
    {
        TWO=2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }
    public enum SUIT
    {
        DIAMONDS = 1,
        CLUBS,
        HEARTS,
        SPADES
    }
    public class Card
    {
        private int rank, suit;
        private Bitmap Image;
        private bool faceUp;
        public bool FaceUp
        {
            get { return faceUp; }
            set 
            { 
                faceUp = value;
                getImageFromFile();
            }
        }
        //default two of diamonds
        public Card()
        {
            rank = (int)RANK.TWO;
            suit = (int)SUIT.DIAMONDS;
            faceUp = false;

        }
        public Card(RANK rank,SUIT suit)
        {
            this.rank = (int)rank;
            this.suit = (int)suit;
            faceUp = false;

        }
        public Card(int rank, int suit)
        {
            if (rank < 1 || rank > 14 || suit < 1 || suit > 4)
                throw new ArgumentOutOfRangeException();
            this.rank=rank;
            this.suit=suit;
            faceUp=false;

        }
        public Card(RANK rank, SUIT suit,bool faceUp)
        {
            this.rank = (int)rank;
            this.suit = (int)suit;
            this.faceUp = faceUp;

        }
        public Card(int rank, int suit,bool faceUp)
        {
            if (rank < 1 || rank > 14 || suit < 1 || suit > 4)
                throw new ArgumentOutOfRangeException();
            this.rank = rank;
            this.suit = suit;
            this.faceUp = faceUp;

        }

        public void setFaceUp()
        {
            this.faceUp = true;
        }
        public Card(Card card)
        {
            this.rank = card.rank;
            this.suit = card.suit;
            this.faceUp = card.faceUp;

        }
        public Card(Card card, bool face)
        {
            this.rank = card.rank;
            this.suit = card.suit;
            this.faceUp = face;

        }
        public static string rankToString(int rank)
        {
            switch (rank)
            {
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                case 14:
                    return "Ace";
                default:
                    return rank.ToString();
            }
        }
        public static string suitToString(int suit)
        {
            switch (suit)
            {
                case 1:
                    return "Diamonds";
                case 2:
                    return "Clubs";
                case 3:
                    return "Hearts";
                default:
                    return "Spades";
            }
        }
        public int getRank()
        {
            return rank;
        }
        public int getSuit()
        {
            return suit;
        }
        //get image from depending on if the card is faceup or down
        private void getImageFromFile()
        {
            ResourceManager rm = Resources.ResourceManager;
            if (faceUp)
            {

                this.Image = (Bitmap)rm.GetObject("_" + suit + "_" + rank);
                // $"{Properties.Resources.}_{ suit }-{ rank}.png");
            }
            else
                this.Image = (Bitmap)rm.GetObject("br");
                    //("Cards\\br.png");
        }
        //get the current image
        public Bitmap getImage()
        {
            if(Image==null)
                getImageFromFile();
            return this.Image;
        }
        public void setRank(RANK rank)
        {
            this.rank = (int)rank;
        }
        public void setCard(RANK rank, SUIT suit)
        {
            this.rank = (int)rank;
            this.suit = (int)suit;
        }
        public void setCard(int rank, int suit)
        {
            if(rank<1||rank>14||suit<1||suit>4)
                throw new ArgumentOutOfRangeException();
            this.rank=rank;
            this.suit=suit;
        }
        //compare rank of cards
        public static bool operator ==(Card a, Card b)
        {
            if (a.rank == b.rank)
                return true;
            else
                return false;
        }
        public static bool operator !=(Card a, Card b)
        {
            if (a.rank != b.rank)
                return true;
            else
                return false;
        }
        public static bool operator <(Card a, Card b)
        {
            if (a.rank < b.rank)
                return true;
            else
                return false;
        }
        public static bool operator >(Card a, Card b)
        {
            if (a.rank > b.rank)
                return true;
            else
                return false;
        }
        public static bool operator <=(Card a, Card b)
        {
            if (a.rank <= b.rank)
                return true;
            else
                return false;
        }
        public static bool operator >=(Card a, Card b)
        {
            if (a.rank >= b.rank)
                return true;
            else
                return false;
        }
    }
    
}
