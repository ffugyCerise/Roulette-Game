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
    public partial class Roulette : Form
    {
        //create gloable varables
        int currentAmount = 100;
        int betAmount;
        double creditCard;
        const int insideBet = 2;
        const int outsideBet = 1;
        const int number0Win = 3;

        Random rand = new Random();

        //create variables for the bets 
        int red1;
        int black2;
        int red3;
        int black4;
        int red5;
        int black6;
        int red7;
        int black8;
        int red9;
        int black10;
        int black11;
        int red12;
        int black13;
        int red14;
        int black15;
        int red16;
        int black17;
        int red18;
        int red19;
        int black20;
        int red21;
        int black22;
        int red23;
        int black24;
        int red25;
        int black26;
        int red27;
        int black28;
        int black29;
        int red30;
        int black31;
        int red32;
        int black33;
        int red34;
        int black35;
        int red36;
        int Number0;
        int oneTo18;
        int nineteenTo36;
        int oneTo12;
        int thirteenTo24;
        int twoFiveTo36;
        int even;
        int red;
        int black;
        int odd;
        int topRole;
        int middleRole;
        int bottomRole;
        int winingAmount;

        //create booleans
        bool redNumber = false;
        bool blackNumber = false;
        bool evenNumber = false;
        bool oddNumber = false;
        bool one2Tweelve = false;
        bool thirteentotwofour = false;
        bool tweentyfiveTOthreesix = false;
        bool one2eighteen = false;
        bool nineteenTOthreesix = false;
        bool tOP = false;
        bool mIDDLE = false;
        bool bOTTOM = false;


        public Roulette()
        {
            InitializeComponent();
        }

        private void Roulette_Load(object sender, EventArgs e)
        {
            //reset starting amount of money
            lblChipAmount.Text = Convert.ToString(currentAmount);
        }

        private void TxtBetAmount_TextChanged(object sender, EventArgs e)
        {
            //check if player bets less than 0
            if (txtBetAmount.Text == "0")
            {
                //let player know they can't bet 0 amount
                MessageBox.Show("sorry you can't bet anything smaller than 1");
                //clear textbox
                txtBetAmount.Text = "";
            }
            //get bet amount from textbox
            if (int.TryParse(txtBetAmount.Text, out betAmount))
            {
                
            }
        }

        private void BtnRed1_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                //let player know they can't bet that much
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if(txtBetAmount.Text == "")
            {
                //let player know they need to enter bet amount
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                //claculate current amount
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button change color
                red1 = red1 + betAmount;
                btnRed1.Enabled = false;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Pink;
                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
            
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            //randomly choose a number
            int randomNumber = rand.Next(0, 37);
            //display the random number
            lblRouletteNumber.Text = Convert.ToString(randomNumber);

            //outside bet code turning on and boolean depending on what color and number it is
            if(randomNumber == 1)
            {
                redNumber = true;
                oddNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                bOTTOM = true;
            }
            else if(randomNumber == 2)
            {
                blackNumber = true;
                evenNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                mIDDLE = true;
            }
            else if(randomNumber == 3)
            {
                redNumber = true;
                oddNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                tOP = true;
            }
            else if(randomNumber == 4)
            {
                blackNumber = true;
                evenNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                bOTTOM = true;
            }
            else if(randomNumber == 5)
            {
                redNumber = true;
                oddNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                mIDDLE = true;
            }
            else if (randomNumber == 6)
            {
                blackNumber = true;
                evenNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                tOP = true;
            }
            else if (randomNumber == 7)
            {
                redNumber = true;
                oddNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                bOTTOM = true;
            }
            else if(randomNumber == 8)
            {
                blackNumber = true;
                evenNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                mIDDLE = true;
            }
            else if(randomNumber == 9)
            {
                redNumber = true;
                oddNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                tOP = true;
            }
            else if (randomNumber == 10)
            {
                blackNumber = true;
                evenNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                bOTTOM = true;
            }
            else if (randomNumber == 11)
            {
                blackNumber = true;
                oddNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                mIDDLE = true;
            }
            else if (randomNumber == 12)
            {
                redNumber = true;
                evenNumber = true;
                one2eighteen = true;
                one2Tweelve = true;
                tOP = true;
            }
            else if (randomNumber == 13)
            {
                blackNumber = true;
                oddNumber = true;
                one2eighteen = true;
                thirteentotwofour = true;
                bOTTOM = true;
            }
            else if (randomNumber == 14)
            {
                redNumber = true;
                evenNumber = true;
                one2eighteen = true;
                thirteentotwofour = true;
                mIDDLE = true;
            }
            else if (randomNumber == 15)
            {
                blackNumber = true;
                oddNumber = true;
                one2eighteen = true;
                thirteentotwofour = true;
                tOP = true;
            }
            else if (randomNumber == 16)
            {
                redNumber = true;
                evenNumber = true;
                one2eighteen = true;
                thirteentotwofour = true;
                bOTTOM = true;
            }
            else if (randomNumber == 17)
            {
                blackNumber = true;
                oddNumber = true;
                one2eighteen = true;
                thirteentotwofour = true;
                mIDDLE = true;
            }
            else if (randomNumber == 18)
            {
                redNumber = true;
                evenNumber = true;
                one2eighteen = true;
                thirteentotwofour = true;
                tOP = true;
            }
            else if (randomNumber == 19)
            {
                redNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                thirteentotwofour = true;
                bOTTOM = true;
            }
            else if (randomNumber == 20)
            {
                blackNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                thirteentotwofour = true;
                mIDDLE = true;
            }
            else if (randomNumber == 21)
            {
                redNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                thirteentotwofour = true;
                tOP = true;
            }
            else if (randomNumber == 22)
            {
                blackNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                thirteentotwofour = true;
                bOTTOM = true;
            }
            else if (randomNumber == 23)
            {
                redNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                thirteentotwofour = true;
                mIDDLE = true;
            }
            else if (randomNumber == 24)
            {
                blackNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                thirteentotwofour = true;
                tOP = true;
            }
            else if (randomNumber == 25)
            {
                redNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                bOTTOM = true;
            }
            else if (randomNumber == 26)
            {
                blackNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                mIDDLE = true;
            }
            else if (randomNumber == 27)
            {
                redNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                tOP = true;
            }
            else if (randomNumber == 28)
            {
                blackNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                bOTTOM = true;
            }
            else if (randomNumber == 29)
            {
                blackNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                mIDDLE = true;
            }
            else if (randomNumber == 30)
            {
                redNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                tOP = true;
            }
            else if (randomNumber == 31)
            {
                blackNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                bOTTOM = true;
            }
            else if (randomNumber == 32)
            {
                redNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                mIDDLE = true;
            }
            else if (randomNumber == 33)
            {
                blackNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                tOP = true;
            }
            else if (randomNumber == 34)
            {
                redNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                bOTTOM = true;
            }
            else if (randomNumber == 35)
            {
                blackNumber = true;
                oddNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                mIDDLE = true;
            }
            else if (randomNumber == 36)
            {
                redNumber = true;
                evenNumber = true;
                nineteenTOthreesix = true;
                tweentyfiveTOthreesix = true;
                tOP = true;
            }
            else
            {
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;
            }
            
            //see if person won
            if (randomNumber == 0 && btnNumber0.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = Number0 * number0Win;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //set all booleans to false
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 1 && btnRed1.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red1 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(randomNumber == 2 && btnBlack2.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black2 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if(randomNumber == 3 && btnRed3.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red3 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if(randomNumber == 4 && btnBlack4.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black4 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                //set all booleans to false
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(randomNumber == 5 && btnRed5.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red5 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if(randomNumber == 6 && btnBlack6.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black6 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(randomNumber == 7 && btnRed7.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red7 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(randomNumber == 8 && btnBlack8.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black8 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 9 && btnRed9.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red9 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 10 && btnBlack10.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black10 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 11 && btnBlack11.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black11 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 12 && btnRed12.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red12 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 13 && btnBlack13.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black13 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 14 && btnRed14.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red14 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 15 && btnBlack15.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black15 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 16 && btnRed16.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red16 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 17 && btnBlack17.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black17 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 18 && btnRed18.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red18 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 19 && btnRed19.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red19 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 20 && btnBlack20.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black20 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 21 && btnRed21.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red21 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 22 && btnBlack22.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black22 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 23 && btnRed23.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red23 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 24 && btnBlack24.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black24 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 25 && btnRed25.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red25 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 26 && btnBlack26.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black26 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 27 && btnRed27.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red27 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 28 && btnBlack28.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black28 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 29 && btnBlack29.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black29 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 30 && btnRed30.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red30 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 31 && btnBlack31.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black31 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 32 && btnRed32.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red32 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 33 && btnBlack33.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black33 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 34 && btnRed34.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red34 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            }
            else if (randomNumber == 35 && btnBlack35.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black35 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (randomNumber == 36 && btnRed36.Enabled == false)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red36 * insideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);
                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(btnRED.Enabled == false && redNumber == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = red * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (btnBLACK.Enabled == false && blackNumber == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = black * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(btnODD.Enabled == false && oddNumber == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = odd * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(btnEVEN.Enabled == false && evenNumber == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = even * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;


            }
            else if(btn1to12.Enabled == false && one2Tweelve == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = oneTo12 * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;


            }
            else if(btn13to24.Enabled == false && thirteentotwofour == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = thirteenTo24 * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;


            }
            else if(btn25to36.Enabled == false && tweentyfiveTOthreesix == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = twoFiveTo36 * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(btn1to18.Enabled == false && one2eighteen == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = oneTo18 * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(btn19to36.Enabled == false && nineteenTOthreesix == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = nineteenTo36 * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if(btnTopRole.Enabled == false && tOP == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = topRole * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;


            }
            else if (btnMiddleRole.Enabled == false && mIDDLE == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = middleRole * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else if (btnBottomRole.Enabled == false && bOTTOM == true)
            {
                //congraguate the winner
                MessageBox.Show("congrats you won");
                //see how much they won
                winingAmount = bottomRole * outsideBet;
                //update their money amount
                currentAmount = currentAmount + winingAmount;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black;

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset all booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;

            }
            else
            {
                //tell them they lost
                MessageBox.Show("99.9% of people give up before the big win! keep trying");

                //reset all buttons 
                btnRed1.Enabled = true;
                btnRed1.ForeColor = Color.White;
                btnRed1.BackColor = Color.Red;

                btnBlack2.Enabled = true;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Black;

                btnRed3.Enabled = true;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Red;

                btnBlack4.Enabled = true;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Black;

                btnRed5.Enabled = true;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Red;

                btnBlack6.Enabled = true;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Black;

                btnRed7.Enabled = true;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Red;

                btnBlack8.Enabled = true;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Black;

                btnRed9.Enabled = true;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Red;

                btnBlack10.Enabled = true;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Black; 

                btnBlack11.Enabled = true;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Black;

                btnRed12.Enabled = true;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Red;

                btnBlack13.Enabled = true;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Black;

                btnRed14.Enabled = true;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Red;

                btnBlack15.Enabled = true;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Black;

                btnRed16.Enabled = true;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Red;

                btnBlack17.Enabled = true;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Black;

                btnRed18.Enabled = true;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Red;

                btnRed19.Enabled = true;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Red;

                btnBlack20.Enabled = true;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Black;

                btnRed21.Enabled = true;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Red;

                btnBlack22.Enabled = true;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Black;

                btnRed23.Enabled = true;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Red;

                btnBlack24.Enabled = true;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Black;

                btnRed25.Enabled = true;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Red;

                btnBlack26.Enabled = true;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Black;

                btnRed27.Enabled = true;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Red;

                btnBlack28.Enabled = true;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Black;

                btnBlack29.Enabled = true;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Black;

                btnRed30.Enabled = true;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Red;

                btnBlack31.Enabled = true;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Black;

                btnRed32.Enabled = true;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Red;

                btnBlack33.Enabled = true;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Black;

                btnRed34.Enabled = true;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Red;

                btnBlack35.Enabled = true;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Black;

                btnRed36.Enabled = true;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Red;

                btnRED.Enabled = true;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Red;

                btnBLACK.Enabled = true;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Black;

                btnNumber0.Enabled = true;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LimeGreen;

                btnODD.Enabled = true;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LimeGreen;

                btnEVEN.Enabled = true;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LimeGreen;

                btn1to12.Enabled = true;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LimeGreen;

                btn1to18.Enabled = true;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LimeGreen;

                btn13to24.Enabled = true;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LimeGreen;

                btn19to36.Enabled = true;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LimeGreen;

                btn25to36.Enabled = true;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LimeGreen;

                btnTopRole.Enabled = true;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LimeGreen;

                btnMiddleRole.Enabled = true;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LimeGreen;

                btnBottomRole.Enabled = true;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LimeGreen;

                //reset booleans
                redNumber = false;
                blackNumber = false;
                evenNumber = false;
                oddNumber = false;
                one2Tweelve = false;
                thirteentotwofour = false;
                tweentyfiveTOthreesix = false;
                one2eighteen = false;
                nineteenTOthreesix = false;
                tOP = false;
                mIDDLE = false;
                bOTTOM = false;

                //set all betted amount to 0
                red1 = 0;
                black2 = 0;
                red3 = 0;
                black4 = 0;
                red5 = 0;
                black6 = 0;
                red7 = 0;
                black8 = 0;
                red9 = 0;
                black10 = 0;
                black11 = 0;
                red12 = 0;
                black13 = 0;
                red14 = 0;
                black15 = 0;
                red16 = 0;
                black17 = 0;
                red18 = 0;
                red19 = 0;
                black20 = 0;
                red21 = 0;
                black22 = 0;
                red23 = 0;
                black24 = 0;
                red25 = 0;
                black26 = 0;
                red27 = 0;
                black28 = 0;
                black29 = 0;
                red30 = 0;
                black31 = 0;
                red32 = 0;
                black33 = 0;
                red34 = 0;
                black35 = 0;
                red36 = 0;
                Number0 = 0;
                oneTo18 = 0;
                nineteenTo36 = 0;
                oneTo12 = 0;
                thirteenTo24 = 0;
                twoFiveTo36 = 0;
                even = 0;
                red = 0;
                black = 0;
                odd = 0;
                topRole = 0;
                middleRole = 0;
                bottomRole = 0;
            } 
        }

        private void BtnBlack2_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black2 = black2 + betAmount;
                btnBlack2.Enabled = false;
                btnBlack2.ForeColor = Color.White;
                btnBlack2.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed3_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red3 = red3 + betAmount;
                btnRed3.Enabled = false;
                btnRed3.ForeColor = Color.White;
                btnRed3.BackColor = Color.Pink;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack4_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black4 = black4 + betAmount;
                btnBlack4.Enabled = false;
                btnBlack4.ForeColor = Color.White;
                btnBlack4.BackColor = Color.Gray;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed5_Click(object sender, EventArgs e)
        {
            
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red5 = red5 + betAmount;
                btnRed5.Enabled = false;
                btnRed5.ForeColor = Color.White;
                btnRed5.BackColor = Color.Pink;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack6_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black6 = black6 + betAmount;
                btnBlack6.Enabled = false;
                btnBlack6.ForeColor = Color.White;
                btnBlack6.BackColor = Color.Gray;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed7_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red7 = red7 + betAmount;
                btnRed7.Enabled = false;
                btnRed7.ForeColor = Color.White;
                btnRed7.BackColor = Color.Pink;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack8_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black8 = black8 + betAmount;
                btnBlack8.Enabled = false;
                btnBlack8.ForeColor = Color.White;
                btnBlack8.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed9_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red9 = red9 + betAmount;
                btnRed9.Enabled = false;
                btnRed9.ForeColor = Color.White;
                btnRed9.BackColor = Color.Pink;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack10_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black10 = black10 + betAmount;
                btnBlack10.Enabled = false;
                btnBlack10.ForeColor = Color.White;
                btnBlack10.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack11_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black11 = black11 + betAmount;
                btnBlack11.Enabled = false;
                btnBlack11.ForeColor = Color.White;
                btnBlack11.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed12_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red12 = red12 + betAmount;
                btnRed12.Enabled = false;
                btnRed12.ForeColor = Color.White;
                btnRed12.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack13_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black13 = black13 + betAmount;
                btnBlack13.Enabled = false;
                btnBlack13.ForeColor = Color.White;
                btnBlack13.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed14_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red14 = red14 + betAmount;
                btnRed14.Enabled = false;
                btnRed14.ForeColor = Color.White;
                btnRed14.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }

        }
        private void BtnBlack15_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black15 = black15 + betAmount;
                btnBlack15.Enabled = false;
                btnBlack15.ForeColor = Color.White;
                btnBlack15.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed16_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red16 = red16 + betAmount;
                btnRed16.Enabled = false;
                btnRed16.ForeColor = Color.White;
                btnRed16.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack17_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black17 = black17 + betAmount;
                btnBlack17.Enabled = false;
                btnBlack17.ForeColor = Color.White;
                btnBlack17.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed18_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red18 = red18 + betAmount;
                btnRed18.Enabled = false;
                btnRed18.ForeColor = Color.White;
                btnRed18.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed19_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red19 = red19 + betAmount;
                btnRed19.Enabled = false;
                btnRed19.ForeColor = Color.White;
                btnRed19.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack20_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black20 = black20 + betAmount;
                btnBlack20.Enabled = false;
                btnBlack20.ForeColor = Color.White;
                btnBlack20.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed21_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red21 = red21 + betAmount;
                btnRed21.Enabled = false;
                btnRed21.ForeColor = Color.White;
                btnRed21.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack22_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black22 = black22 + betAmount;
                btnBlack22.Enabled = false;
                btnBlack22.ForeColor = Color.White;
                btnBlack22.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed23_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red23 = red23 + betAmount;
                btnRed23.Enabled = false;
                btnRed23.ForeColor = Color.White;
                btnRed23.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack24_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black24 = black24 + betAmount;
                btnBlack24.Enabled = false;
                btnBlack24.ForeColor = Color.White;
                btnBlack24.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed25_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red25 = red25 + betAmount;
                btnRed25.Enabled = false;
                btnRed25.ForeColor = Color.White;
                btnRed25.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack26_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black26 = black26 + betAmount;
                btnBlack26.Enabled = false;
                btnBlack26.ForeColor = Color.White;
                btnBlack26.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed27_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red27 = red27 + betAmount;
                btnRed27.Enabled = false;
                btnRed27.ForeColor = Color.White;
                btnRed27.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack28_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black28 = black28 + betAmount;
                btnBlack28.Enabled = false;
                btnBlack28.ForeColor = Color.White;
                btnBlack28.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack29_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black29 = black29 + betAmount;
                btnBlack29.Enabled = false;
                btnBlack29.ForeColor = Color.White;
                btnBlack29.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed30_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red30 = red30 + betAmount;
                btnRed30.Enabled = false;
                btnRed30.ForeColor = Color.White;
                btnRed30.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack31_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black31 = black31 + betAmount;
                btnBlack31.Enabled = false;
                btnBlack31.ForeColor = Color.White;
                btnBlack31.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed32_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red32 = red32 + betAmount;
                btnRed32.Enabled = false;
                btnRed32.ForeColor = Color.White;
                btnRed32.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack33_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black33 = black33 + betAmount;
                btnBlack33.Enabled = false;
                btnBlack33.ForeColor = Color.White;
                btnBlack33.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed34_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red34 = red34 + betAmount;
                btnRed34.Enabled = false;
                btnRed34.ForeColor = Color.White;
                btnRed34.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBlack35_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black35 = black35 + betAmount;
                btnBlack35.Enabled = false;
                btnBlack35.ForeColor = Color.White;
                btnBlack35.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRed36_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red36 = red36 + betAmount;
                btnRed36.Enabled = false;
                btnRed36.ForeColor = Color.White;
                btnRed36.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnNumber0_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to 0 disable the button
                Number0 = Number0 + betAmount;
                btnNumber0.Enabled = false;
                btnNumber0.ForeColor = Color.White;
                btnNumber0.BackColor = Color.LightGreen;


                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnRED_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to red disable the button
                red = red + betAmount;
                btnRED.Enabled = false;
                btnRED.ForeColor = Color.White;
                btnRED.BackColor = Color.Pink;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBLACK_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to black disable the button
                black = black + betAmount;
                btnBLACK.Enabled = false;
                btnBLACK.ForeColor = Color.White;
                btnBLACK.BackColor = Color.Gray;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnEVEN_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to even disable the button
                even = even + betAmount;
                btnEVEN.Enabled = false;
                btnEVEN.ForeColor = Color.White;
                btnEVEN.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnODD_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet to odd disable the button
                odd = odd + betAmount;
                btnODD.Enabled = false;
                btnODD.ForeColor = Color.White;
                btnODD.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void Btn1to18_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                oneTo18 = oneTo18 + betAmount;
                btn1to18.Enabled = false;
                btn1to18.ForeColor = Color.White;
                btn1to18.BackColor = Color.LightGreen;   

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void Btn19to36_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                nineteenTo36 = nineteenTo36 + betAmount;
                btn19to36.Enabled = false;
                btn19to36.ForeColor = Color.White;
                btn19to36.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void Btn1to12_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                oneTo12 = oneTo12 + betAmount;
                btn1to12.Enabled = false;
                btn1to12.ForeColor = Color.White;
                btn1to12.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void Btn13to24_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                thirteenTo24 = thirteenTo24 + betAmount;
                btn13to24.Enabled = false;
                btn13to24.ForeColor = Color.White;
                btn13to24.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void Btn25to36_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                twoFiveTo36 = twoFiveTo36 + betAmount;
                btn25to36.Enabled = false;
                btn25to36.ForeColor = Color.White;
                btn25to36.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnBottomRole_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                bottomRole = bottomRole + betAmount;
                btnBottomRole.Enabled = false;
                btnBottomRole.ForeColor = Color.White;
                btnBottomRole.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnMiddleRole_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                middleRole = middleRole + betAmount;
                btnMiddleRole.Enabled = false;
                btnMiddleRole.ForeColor = Color.White;
                btnMiddleRole.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void BtnTopRole_Click(object sender, EventArgs e)
        {
            //check if the amount is larger than its current amount
            if (betAmount > currentAmount)
            {
                MessageBox.Show("You do not have enough money to make that bet");
                //clear the textbox
                lblBetAmount.Text = "";
            }
            else if (txtBetAmount.Text == "")
            {
                MessageBox.Show("please enter your bet amount");
            }
            else
            {
                currentAmount = currentAmount - betAmount;
                //add the bet and disable the button
                topRole = topRole + betAmount;
                btnTopRole.Enabled = false;
                btnTopRole.ForeColor = Color.White;
                btnTopRole.BackColor = Color.LightGreen;

                //update the chip amount
                lblChipAmount.Text = Convert.ToString(currentAmount);
                txtBetAmount.Text = "";
            }
        }

        private void TxtCardnumber_TextChanged(object sender, EventArgs e)
        {
            //get creditcard number
            if (Double.TryParse(txtCardnumber.Text, out creditCard))
            {

            }
        }

        private void BtnCreditcardEnter_Click(object sender, EventArgs e)
        {
            //randomly choose a number
            int randomNumber = rand.Next(0, 11);

            //broadcast their creditcard number in message box and give money accourding
            if(randomNumber == 0)
            {
                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's no money in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if(randomNumber == 1)
            {
                currentAmount = currentAmount + 1;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 1 chip in this card, enjoy your bet!");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if(randomNumber == 2)
            {
                currentAmount = currentAmount + 2;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 2 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 3)
            {
                currentAmount = currentAmount + 3;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 3 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 4)
            {
                currentAmount = currentAmount + 4;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 4 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 5)
            {
                currentAmount = currentAmount + 5;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 5 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 6)
            {
                currentAmount = currentAmount + 6;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 6 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 7)
            {
                currentAmount = currentAmount + 7;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 7 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 8)
            {
                currentAmount = currentAmount + 8;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 8 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else if (randomNumber == 9)
            {
                currentAmount = currentAmount + 9;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 9 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }
            else
            {
                currentAmount = currentAmount + 10;
                lblChipAmount.Text = Convert.ToString(currentAmount);

                MessageBox.Show("ah yes! " + Convert.ToString(creditCard) + " there's 10 chips in this card.");
                //clear textbox
                txtCardnumber.Text = "";
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //close all forms
            Environment.Exit(1);
        }

        private void LblHow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //transfer user to tutorial video
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=wRciBlaiCMU");

        }
    }
}
