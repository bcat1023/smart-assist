using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Assist
{
    public partial class Startscreen : Form
    {
        public int timeLeft;

        public Startscreen()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;

            }

            else

            {

                timer1.Stop();

                new Dash().Show();

                this.Hide();
            }
        }
        private void Startscreen_Load(object sender, EventArgs e)
        {
            //The timer starts
            timeLeft = 100;
            timer1.Start();
        }
    }
}
