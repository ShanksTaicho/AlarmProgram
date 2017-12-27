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

namespace Alarm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(textBox1.Text==label1.Text)
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = "ding.wav";
                sound.Play();
                MessageBox.Show("Alarm Time");
                //ding.wav name and extension of the song played by the alarm - alarm tarafından çalınan şarkının adı ve uzantısı
            }
        }
    }
}
