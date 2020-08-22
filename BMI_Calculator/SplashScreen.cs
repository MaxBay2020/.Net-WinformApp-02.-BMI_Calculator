using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            enter_btn.BringToFront();
            exit_btn.BringToFront();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate () { new MainForm().ShowDialog(); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
