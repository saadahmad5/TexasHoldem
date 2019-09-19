using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHoldem
{
    public partial class Form1 : Form
    {
        Game game;
        Pot pot;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            pot = new Pot();
            refresh();


        }

        void refresh()
        {
            pictureBox1.Image = game.playerCard1();
            //pictureBox8.Image = game.compCard1();
            pictureBox2.Image = game.playerCard2();
           // pictureBox9.Image = game.compCard2();

            pictureBox3.Image = game.river_card1();
            pictureBox4.Image = game.river_card2();
            pictureBox5.Image = game.river_card3();
            pictureBox6.Image = game.river_card4();
            pictureBox7.Image = game.river_card5();

            label1.Text = Convert.ToString(pot.getComputerMoney());
            label2.Text = Convert.ToString(pot.getPotMoney());
            label3.Text = Convert.ToString(pot.getPersonMoney());

            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            pot.addComputerMoney(game.get_money_computer());
            pot.addPersonMoney(game.get_money_player());
            pictureBox8.Image = Properties.Resources.br;
            pictureBox9.Image = Properties.Resources.br;
            game = new Game();
            
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox1.Text);
            game.Raise_Money(amount);
            pot.subPersonMoney(amount);
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;


            label1.Text = Convert.ToString(pot.getComputerMoney());
            label2.Text = Convert.ToString(pot.getPotMoney());
            label3.Text = Convert.ToString(pot.getPersonMoney());

            ComputerMove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Check();
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;


            label1.Text = Convert.ToString(pot.getComputerMoney());
            label2.Text = Convert.ToString(pot.getPotMoney());
            label3.Text = Convert.ToString(pot.getPersonMoney());

            ComputerMove();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ComputerMove()
        {
            pictureBox8.Image = game.compCard1();
            pictureBox9.Image = game.compCard2();
            pot.subComputerMoney(10);
            String temp = game.ComputerMove();
            label6.Text = Convert.ToString(temp);
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;


            label1.Text = Convert.ToString(pot.getComputerMoney());
            label2.Text = Convert.ToString(pot.getPotMoney());
            label3.Text = Convert.ToString(pot.getPersonMoney());
        }
    }
}
