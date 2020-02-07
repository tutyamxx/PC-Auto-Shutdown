using System;
using System.Windows.Forms;

namespace PC_Auto_Shutdown
{
    public partial class Form1 : Form
    {
        int TimerSeconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                TimerSeconds = 900;  // 15 minutes
            }

            else if (radioButton2.Checked == true)
            {
                TimerSeconds = 1800; // 30 minutes
            }

            else if (radioButton3.Checked == true)
            {
                TimerSeconds = 3600;    // 1 hour
            }

            else if (radioButton4.Checked == true)
            {
                TimerSeconds = 7200;    // 2 hours
            }

            MessageBox.Show("Okay mate 🙋‍♂️, timer started!");
            System.Diagnostics.Process.Start("shutdown", "-s -t " + TimerSeconds);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
            MessageBox.Show("Timers are reset!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 WAT = new Form2();
            WAT.Show();
        }
    }
}