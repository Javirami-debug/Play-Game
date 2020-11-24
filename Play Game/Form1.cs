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

namespace Play_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayButton.ForeColor = Color.Black;
            PlayButton.BackColor = Color.Black;
            Thread.Sleep(1000);
            Countdown.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            Countdown.ForeColor = Color.Black;
            SoundPlayer player = new SoundPlayer(Properties.Resources.Air_Leaking_Out_Sound_SoundBible_com_714635080);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Jump_SoundBible_com_1007297584);
            Number.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            Number.ForeColor = Color.Black;
            Number2.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            Number2.ForeColor = Color.Black;
            Refresh();
            Thread.Sleep(1000);
            Number4.ForeColor = Color.White;
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.Car_Engine_Revving_SoundBible_com_296716119);
            Number4.ForeColor = Color.Black;
            GoLabel.ForeColor = Color.White;
            Thread.Sleep(100);
            GoLabel.ForeColor = Color.Black; 


















        }

        private void Countdown_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Countdown.ForeColor = Color.Black;
            Refresh();
            Thread.Sleep(1000);
            Number.ForeColor = Color.Black;
            Refresh();
            Thread.Sleep(1000);
            Number2.ForeColor = Color.Black;


            
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            Number4.ForeColor = Color.Black;

        }
    }
}
