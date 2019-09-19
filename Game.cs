using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    class Game
    {
        int money_player;
        int money_computer;
        int money_pot;
        Hand player;
        Hand computer;
        Deck deck;

        public Game()
        {
            money_player = 0;
            money_computer = 0;
            money_pot = 0;
            deck = new Deck();
            deck.Shuffle();
            player = new Hand();
            computer = new Hand();
        }

        public void Raise_Money(int amount)
        {
            money_player -= amount;
            money_pot += amount;
        }

        public Hand getPlayer()
        {
            return player;
        }

        public Hand getComputer()
        {
            return computer;
        }

        public void Check()
        {
            int amount = 0;
            Raise_Money(amount);
            money_pot += amount;
        }

        void playerWin()
        {
            money_player += money_pot*2;
            money_pot = 0;
        }

        void computerWin()
        {
            money_computer += money_pot*2;
            money_pot = 0;
        }

        void drawWin()
        {
            int temp = money_pot;
            money_player = temp;
            money_computer= temp;
            money_pot = 0;
        }

        public string ComputerMove()
        {
            Hand temp1 = HandCombination.getBestHand(player);
            Hand temp2 = HandCombination.getBestHand(computer);

            if((temp1 > temp2) && (temp2 < temp1))
            {
                playerWin();
                return "Player Win";
            }
            else if((temp2 > temp1) && ( temp1 < temp2))
            {
                computerWin();
                return "Computer Win";
            }
            else
            {
                drawWin();
                return "Draw";
            }
        }

        public int get_money_player()
        {
            return money_player;
        }

        public int get_money_pot()
        {
            return money_pot;
        }

        public int get_money_computer()
        {
            return money_computer;
        }


        public Image river_card1()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            computer.Add(temp);
            return temp.getImage();
        }

        public Image river_card2()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            computer.Add(temp);
            return temp.getImage();
        }
        public Image river_card3()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            computer.Add(temp);
            return temp.getImage();
        }
        public Image river_card4()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            computer.Add(temp);
            return temp.getImage();
        }
        public Image river_card5()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            computer.Add(temp);
            return temp.getImage();
        }

        public Image playerCard1()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            return temp.getImage();
        }

        public Image playerCard2()
        {
            Card temp = deck.Deal(true);
            player.Add(temp);
            return temp.getImage();
        }

        public Image compCard1()
        {
            Card temp = deck.Deal(true);
            computer.Add(temp);
            return temp.getImage();
        }
        public Image compCard2()
        {
            Card temp = deck.Deal(true);
            computer.Add(temp);
            return temp.getImage();
        }


    }
}
