using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BollywoodCinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList CustomersList = new LinkedList();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 60; i++)
            {
                CustomersList.CreatePos(null);
            }
        }

        private void holdButton_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer();

            customers.NameSurname = nameSurnameTextBox.Text;
            customers.SeatNumber = Convert.ToInt32(seatNumberTextBox.Text);

            CustomersList.InsertPos(customers, customers.SeatNumber);

            nameSurnameTextBox.Text = " ";
            seatNumberTextBox.Text = " ";

            MessageBox.Show("Yer ayırıldı!");
        }

        private void fullSeatsButton_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 1; i <= 60; i++)
            {
                Node node = (Node)CustomersList.GetElement(i);
                if (node.Data != null)
                {
                    Customer customer = (Customer)node.Data;
                    str += customer.NameSurname + " " + "Koltuk Numaranız : " + customer.SeatNumber + Environment.NewLine;
                }
            }

            MessageBox.Show(str);
        }
    }
}
