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
    public partial class choose_a_game : Form
    {
        public choose_a_game()
        {
            InitializeComponent();
        }

        private void Choose_a_game_Load(object sender, EventArgs e)
        {
            //deenable all buttons besides 6
            btnR1.Enabled = false;
            btnR2.Enabled = false;
            btnR3.Enabled = false;
            btnR4.Enabled = false;
            btnR5.Enabled = false;
            btnR7.Enabled = false;
            btnR8.Enabled = false;
            
        }

        private void BtnR6_Click(object sender, EventArgs e)
        {
            //switch form to roulette of the game
            Roulette f4 = new Roulette();
            f4.Show();
            //hide this form
            this.Hide();
        }
    }
}
