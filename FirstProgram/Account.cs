using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstProgram
{
    public partial class Account : Form
    {
        LogIn logIn = new LogIn();
        public Account()
        {
           
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGINButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                logIn.ReadFromFile();
                User user = new User(NameBox.Text.ToString(), PasswordBox1.Text.ToString());
                User oldUser = logIn.ReturnUser(user);
                
                if(user.GetName()==oldUser.GetName() && user.GetPassword()==oldUser.GetPassword() )
                {
                    Order order = new Order(user.GetName());
                    order.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid data!");
                }


            }catch(Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();
        

        }
    }
}
