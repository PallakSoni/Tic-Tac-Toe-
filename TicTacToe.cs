/*
 * 
 * Assignment-1 
 * 
 * Created By: Palak Soni
 * 
 * 
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        Image X = Properties.Resources.X_image;
        Image O = Properties.Resources.O_IMAGE;
        Image initial = Properties.Resources.Initial_Border;
        int[,] arr = new int[3, 3];
        int tieCount = 0;
        

        bool player1 = true; 
        public TicTacToe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method for initial image
        /// Game starts with 'X'
        /// </summary>
        /// <param name="picture"></param>
        private void ImageShow(PictureBox picture)
        {
            if (player1 == true)
            {
                picture.Image = X;
                player1 = false;
            }
            else
            {
                picture.Image = O;
                player1 = true;
            }
            tieCount++;
            picture.Enabled = false;
            
        }

        /// <summary>
        /// Button click event for every button to show image
        /// And checking result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb00_Click(object sender, EventArgs e)
        {
            ImageShow(ptb00);
            CheckResult();
        }

        private void ptb01_Click(object sender, EventArgs e)
        {
            ImageShow(ptb01);
            CheckResult();
        }

        private void ptb02_Click(object sender, EventArgs e)
        {
            ImageShow(ptb02);
            CheckResult();
        }

        private void ptb10_Click(object sender, EventArgs e)
        {
            ImageShow(ptb10);
            CheckResult();
        }

        private void ptb11_Click(object sender, EventArgs e)
        {
            ImageShow(ptb11);
            CheckResult();
        }

        private void ptb12_Click(object sender, EventArgs e)
        {
            ImageShow(ptb12);
            CheckResult();
        }

        private void ptb20_Click(object sender, EventArgs e)
        {
            ImageShow(ptb20);
            CheckResult();
        }

        private void ptb21_Click(object sender, EventArgs e)
        {
            ImageShow(ptb21);
            CheckResult();
        }

        private void ptb22_Click(object sender, EventArgs e)
        {
            ImageShow(ptb22);
            CheckResult();
        }

        /// <summary>
        /// Checking result with the position
        /// By Rows, Columns, Diagonally
        /// </summary>

        public void CheckResult()
        {
            PictureBox picture = new PictureBox();
            picture.Image = initial;
          
            // ROWS CHECK

            if (ptb00.Image== X && ptb01.Image==X && ptb02.Image==X)
            {
              var result= MessageBox.Show("Yaay!! X Wins.","Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result==DialogResult.OK)
                {
                    RestartGame();
                }
              
            }
            else if (ptb00.Image == O && ptb01.Image == O && ptb02.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb10.Image == O && ptb11.Image == O && ptb12.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb10.Image == X && ptb11.Image == X && ptb12.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb20.Image == O && ptb21.Image == O && ptb22.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ptb20.Image == X && ptb21.Image == X && ptb22.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();

                }
            }

            // DIAGONAL CHECK

            else if (ptb00.Image == O && ptb11.Image == O && ptb22.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb00.Image == X && ptb11.Image == X && ptb22.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb02.Image == X && ptb11.Image == X && ptb20.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb02.Image == O && ptb11.Image == O && ptb20.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }

            //COLUMN CHECK

            else if (ptb00.Image == O && ptb10.Image == O && ptb20.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb00.Image == X && ptb10.Image == X && ptb20.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb01.Image == X && ptb11.Image == X && ptb21.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb01.Image == O && ptb11.Image == O && ptb21.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb02.Image == X && ptb12.Image == X && ptb22.Image == X)
            {
                var result = MessageBox.Show("Yaay!! X Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
            else if (ptb02.Image == O && ptb12.Image == O && ptb22.Image == O)
            {
                var result = MessageBox.Show("Yaay!! O Wins.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }

            // Draw
            else if (tieCount==9)
            {
                var result = MessageBox.Show("Its a Draw", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    RestartGame();
                }
            }
        }

        public void RestartGame()
        {

           
    
            ptb00 = ptb01 = ptb02=
                ptb10 = ptb11 = ptb12
                = ptb20 = ptb21= ptb22= null;


        }
    }
}