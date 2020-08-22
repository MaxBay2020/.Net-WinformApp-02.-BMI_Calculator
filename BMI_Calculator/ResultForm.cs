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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            result_lb.Text = Cong_App.value;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(delegate () { new MainForm().ShowDialog(); });
            //th.Start();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howto_btn_Click(object sender, EventArgs e)
        {
            //KeepFitForm keepFitForm = new KeepFitForm();
            Thread th = new Thread(delegate () { new KeepFitForm().ShowDialog(); });
            th.Start();
            this.Close();
        }
    }
}
