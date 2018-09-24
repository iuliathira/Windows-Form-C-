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
    public partial class Sign :Form
    {
        LogIn login = new LogIn();
        public Sign()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CREATEButton_Click(object sender, EventArgs e)
        {
            string nume = NameTextBox.Text;
            string name = UserTextBox1.Text;
            string pass = PassTextBox1.Text;
            try
            {
                login.AddUser(name, pass);
            } catch(UsernameAlreadyTakenException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
