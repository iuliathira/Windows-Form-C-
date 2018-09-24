using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetClientSizeCore(1282, 630);
            homeCustomControl1.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            homeCustomControl1.BringToFront();
            
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            firstCustomControl2.BringToFront();
        }

        private void PastaButton_Click(object sender, EventArgs e)
        {
            secondCustomControl1.BringToFront();
            
        }

        private void FacebookButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thira.iulia");
        }

        private void InstaButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/thiraiulia/?hl=ro");
        }

        private void TwitterButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/IuliaThira");
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
        }
    }
}
