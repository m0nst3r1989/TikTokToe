using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTikToe
{
    public partial class Form1 : Form
    {
        int checkPlayer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (checkPlayer == 0)
            {

                firstCell.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                firstCell.Text = "O";

                checkPlayer--;

            }


            firstCell.Enabled = false;


            winCheck();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //test the players chance

            if (checkPlayer == 0)
            {

                SecondCell.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                SecondCell.Text = "O";

                checkPlayer--;

            }

            //already selected cells should be disbled

            SecondCell.Enabled = false;

            //check for winners
            winCheck();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //test the winners

            if (checkPlayer == 0)
            {

                thirdCell.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                thirdCell.Text = "O";

                checkPlayer--;

            }

            thirdCell.Enabled = false;


            winCheck();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //test whose turn

            if (checkPlayer == 0)
            {

                cell4.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                cell4.Text = "O";

                checkPlayer--;

            }

            //already selected button, so can't change

            cell4.Enabled = false;


            winCheck();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //check the turn and assign X or 0

            if (checkPlayer == 0)
            {

                cell5.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                cell5.Text = "O";

                checkPlayer--;

            }


            cell5.Enabled = false;


            winCheck();

        }

        //to perform cell6 click
        private void button6_Click(object sender, EventArgs e)
        {

            //check the turn and assign X or 0
            if (checkPlayer == 0)
            {

                cell6.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                cell6.Text = "O";

                checkPlayer--;

            }


            cell6.Enabled = false;


            winCheck();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            //check the turn and assign X or 0

            if (checkPlayer == 0)
            {

                cell7.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                cell7.Text = "O";

                checkPlayer--;

            }


            cell7.Enabled = false;


            winCheck();

        }


        private void button8_Click_1(object sender, EventArgs e)
        {

            //check the turn and assign X or 0
            if (checkPlayer == 0)
            {

                cell8.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                cell8.Text = "O";

                checkPlayer--;

            }

            cell8.Enabled = false;


            winCheck();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            //check the turn and assign X or 0

            if (checkPlayer == 0)
            {

                cell9.Text = "X";

                checkPlayer++;

            }

            else if (checkPlayer == 1)
            {

                cell9.Text = "O";

                checkPlayer--;

            }


            cell9.Enabled = false;


            winCheck();

        }

        void winCheck()
        {

            //check the winner

            if (firstCell.Text != "" && SecondCell.Text != "" && thirdCell.Text != "" &&

            cell4.Text != "" && cell5.Text != "" && cell6.Text != "" &&

            cell7.Text != "" && cell8.Text != "" && cell9.Text != "")
            {

                resultBox.Text = "Game Tied";

            }

            //assign the letter

            if (firstCell.Text == "X" && cell5.Text == "X" && cell9.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (thirdCell.Text == "X" && cell5.Text == "X" && cell7.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            //check win for x

            if (firstCell.Text == "X" && SecondCell.Text == "X" && thirdCell.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (cell4.Text == "X" && cell5.Text == "X" && cell6.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (cell7.Text == "X" && cell8.Text == "X" && cell9.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            //winCheck columns for X

            if (firstCell.Text == "X" && cell4.Text == "X" && cell7.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (SecondCell.Text == "X" && cell5.Text == "X" && cell8.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (thirdCell.Text == "X" && cell6.Text == "X" && cell9.Text == "X")
            {

                resultBox.Text = "Player X wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            //check whether 0 wins

            if (firstCell.Text == "O" && cell5.Text == "O" && cell9.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (thirdCell.Text == "O" && cell5.Text == "O" && cell7.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            //winCheck rows for O

            if (firstCell.Text == "O" && SecondCell.Text == "O" && thirdCell.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (cell4.Text == "O" && cell5.Text == "O" && cell6.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (cell7.Text == "O" && cell8.Text == "O" && cell9.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            //check for winner 0

            if (firstCell.Text == "O" && cell4.Text == "O" && cell7.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (SecondCell.Text == "O" && cell5.Text == "O" && cell8.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

            if (thirdCell.Text == "O" && cell6.Text == "O" && cell9.Text == "O")
            {

                resultBox.Text = "Player O wins";

                firstCell.Enabled = false;

                SecondCell.Enabled = false;

                thirdCell.Enabled = false;

                cell4.Enabled = false;

                cell5.Enabled = false;

                cell6.Enabled = false;

                cell7.Enabled = false;

                cell8.Enabled = false;

                cell9.Enabled = false;

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

            firstCell.Text = "";

            firstCell.Enabled = true;

            SecondCell.Text = "";

            SecondCell.Enabled = true;

            thirdCell.Text = "";

            thirdCell.Enabled = true;

            cell4.Text = "";

            cell4.Enabled = true;

            cell5.Text = "";

            cell5.Enabled = true;

            cell6.Text = "";

            cell6.Enabled = true;

            cell7.Text = "";

            cell7.Enabled = true;

            cell8.Text = "";

            cell8.Enabled = true;

            cell9.Text = "";

            cell9.Enabled = true;

            resultBox.Text = "";

            checkPlayer = 0;

        }

        private void button11_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

