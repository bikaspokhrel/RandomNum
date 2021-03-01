using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RandomNum
{
    public partial class myform : Form
    {
        public myform()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            SoundPlayer sndPlayer = new SoundPlayer(Resource1.gun_gunshot_01); // this is an instance to play the sound
            sndPlayer.Play();
            int max = Convert.ToInt32(txtInput.Text); //this is a variable where user can insert the maximum number value.
            Random random1 = new Random(); //this is a random number generator
            int randno = random1.Next(0,max);
            lblOutput.Text = Convert.ToString(randno);
            if(randno == 0)
            {
                pctOutput.Image = Resource1.image2; //if the random number is 0, image2 will be displayed in the picture box
            }
            if(randno == 1)
            {
                pctOutput.Image = Resource1.a; //if the random number is 1, a will be displayed in the picture box
            }
        }

    }
}
