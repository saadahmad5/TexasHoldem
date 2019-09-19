using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    public class Pot
    {
        int ComputerMoney;
        int PersonMoney;
        int PotMoney;

        public Pot()
        {
            ComputerMoney = 100;
            PersonMoney = 100;
            PotMoney = 0;
        }

        public void subComputerMoney(int amt)
        {
            ComputerMoney -= amt;
            PotMoney += amt;
        }

        public void addComputerMoney(int amt)
        {
            ComputerMoney += amt;
            PotMoney = 0;
        }

        public void addPersonMoney(int amt)
        {
            PersonMoney += amt;
            PotMoney = 0;
        }

        public void subPersonMoney(int amt)
        {
            PersonMoney -= amt;
            PotMoney += amt;
        }

        public int getPersonMoney()
        {
            return PersonMoney;
        }

        public int getComputerMoney()
        {
            return ComputerMoney;
        }

        public int getPotMoney()
        {
            return PotMoney;
        }
    }
}
