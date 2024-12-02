using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLetsPlay_Click(object sender, EventArgs e)
        {
            //check if checkbox is checked if its checked move on to choose a game if not check display a messagebox telling person to play
            if(cb18yearsOld.Checked == false)
            {
                MessageBox.Show("You must be 18 or older to play this game");
            }
            else
            {
                choose_a_game f2 = new choose_a_game();
                f2.Show();
                //hide this form
                this.Hide();
            }
        }
    }
}
