using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SriLankaRMVCalculator
{
    public partial class LoginCover : Form
    {
        public LoginCover()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            pb_initial_load.Value = startpoint;
            if (pb_initial_load.Value == 100)
            {
                pb_initial_load.Value = 0;
                timer1.Stop();
                RMVMain log = new RMVMain();
                this.Hide();
                log.Show();
            }

        }

        private void LoginCover_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
