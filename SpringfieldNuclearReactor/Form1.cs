using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Diagnostics;

namespace SpringfieldNuclearReactor
{

    public partial class Form1 : Form
    {
        bool reactorsStarted = false;
        Stopwatch leftReactorWatch = new Stopwatch();
        Stopwatch rightReactorWatch = new Stopwatch();
        bool rightReactorRed = true;
        bool leftReactorRed = true;
        Stopwatch flashTimer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void titleLable_Click(object sender, EventArgs e)
        {
           
        }

        private void startReactorButton_Click(object sender, EventArgs e)
        {
            rightReactorWatch.Start();
            if (reactorsStarted == false)
            {
                //Form1.text = "MELTDOWN"
                //Changes the Reactor Colours
                reactor1StateLabel.BackColor = Color.White;
                reactor2StateLabel.BackColor = Color.White;
                startReactorButton.Text = "Reactors Started";

                //Issues a meldown
                SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
                alertPlayer.Play();
                outputLabel.Text = "Meltdown Imminent";
                outputLabel.ForeColor = Color.Red;
                outputLabel.BackColor = Color.Silver;

                //Redraw to show changes and pause for 1 min
                Refresh();
                Thread.Sleep(1000);

                //Change State Labels
                reactor1StateLabel.BackColor = Color.Red;
                reactor2StateLabel.BackColor = Color.Red;

                for (int i = 0; i <= 5; i++)
                {
                    if (i % 2 == 1 || i == 1)
                    {
                        //Change font and background colour of output label
                        outputLabel.ForeColor = Color.White;
                        outputLabel.BackColor = Color.Red;

                        //Redraw to show changes and pause for 1 min
                        Refresh();
                        Thread.Sleep(450);
                    }
                    if (i % 2 == 0)
                    {
                        //Change font and background colour of output label
                        outputLabel.ForeColor = Color.Red;
                        outputLabel.BackColor = Color.White;

                        //Redraw to show changes and pause for 1 min
                        Refresh();
                        Thread.Sleep(450);
                    }
                    bool yes = rightReactorWatch.ElapsedMilliseconds > 200;
                    //titleLable.Text = yes.ToString();
                    reactorsStarted = true;
                }
            }
        }

        private void rightReactorClick(object sender, EventArgs e)
        {
            if (reactorsStarted == true && rightReactorRed == true)
            {

                reactor2StateLabel.BackColor = Color.LawnGreen;
                rightReactorWatch.Start();
            }
            else
            {
                rightReactorRed = true;
                reactor2Label.BackColor = Color.Red;
            }
        }


        private void leftReactorClick(object sender, EventArgs e)
        {
            if (reactorsStarted == true && leftReactorRed == true)
            {
                reactor1StateLabel.BackColor = Color.LawnGreen;
                leftReactorWatch.Start();
                for (int i = 1; i <= 5; i++)
                {
                    while (leftReactorWatch.ElapsedMilliseconds < 200)
                    {
                        if (i == 2)
                        {
                            reactor1StateLabel.BackColor = Color.GreenYellow;
                        }
                        if (i == 3)
                        {
                            reactor1StateLabel.BackColor = Color.Yellow;
                        }
                        if (i == 4)
                        {
                            reactor1StateLabel.BackColor = Color.Orange;
                        }
                        if (i == 5)
                        {
                            reactor1StateLabel.BackColor = Color.OrangeRed;
                            leftReactorRed = true;
                        }
                        if (i == 5)
                        {
                            reactor1StateLabel.BackColor = Color.Red;
                            leftReactorRed = true;
                        }
                    }
                    leftReactorWatch.Reset();
                }
                reactor1StateLabel.BackColor = Color.Red;
                leftReactorRed = true;
            }
            else
            {
                leftReactorRed = true;
                reactor1Label.BackColor = Color.Red;
            }


        }

        private void reactor1Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
