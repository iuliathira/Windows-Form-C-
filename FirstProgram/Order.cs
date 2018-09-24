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
    public partial class Order : Form
    {
        double totalSum = 0;
        public Order(string name)
        {
            InitializeComponent();
            NRLabel.Text=totalSum.ToString() + " $";
            SetUserName(name);
        }
        public void SetUserName(string Name)
        {
            NameLabel.Text = Name;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string order = "1 x Canibale Pizza - $4.29";
            totalSum += 4.29;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string order = "1 x Mexican Pizza - $4.49";
            totalSum += 4.49;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Special Pizza - $5.49";
            totalSum += 5.49;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Carbonara Pizza - $3.99";
            totalSum += 3.99;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Vegan Pizza - $4.99";
            totalSum += 4.99;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }
        private void Button6_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Pasta All’Amatriciana - $5.49";
            totalSum += 5.49;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }
        private void Button7_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Pasta Pollo E Funghi - $4.99";
            totalSum += 4.99;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }
        private void Button8_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Pasta Pesto - $3.49";
            totalSum += 3.49;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }
        private void Button9_Click_1(object sender, EventArgs e)
        {
            string order = "1 x Pasta Al Tonno - $4.49";
            totalSum += 4.49;
            NRLabel.Text = totalSum.ToString() + " $";
            OrderListBox.Items.Add(order);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            NRLabel.Text = "0 $";
            OrderListBox.Items.Clear();
        }
    }
}
