using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        //public string firstName { get; set; }
        //public string LastName { get; set; }
        //public string Address1 { get; set; }
        //public string Address2 { get; set; }
        //public string cardType { get; set; }
        //public string CardNum { get; set; }
        //public string CSC { get; set; }
        //public string ExprirationDate { get; set; }
        //public string Email { get; set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        double Total = 0.0;
        private void btnHipop_Click(object sender, EventArgs e)
        {
            Hip_Hop f1 = new Hip_Hop();
            f1.ShowDialog();

            txtHPrice.Text = f1.Price;
            double HPrice = Convert.ToDouble(this.txtHPrice.Text);
            Total += HPrice;
            txtPrice.Text = Convert.ToString(Total);

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            Pop f2 = new Pop();
            f2.ShowDialog();

            txtPopPrice.Text = f2.PopPrice;
            double PPrice = Convert.ToDouble(this.txtPopPrice.Text);
            Total += PPrice;
            txtPrice.Text = Convert.ToString(Total);
        }

        private void btnCounrty_Click(object sender, EventArgs e)
        {
            Country f3 = new Country();
            f3.ShowDialog();

            txtCPrice.Text = f3.CountryPrice;
            double CPrice = Convert.ToDouble(this.txtCPrice.Text);
            Total += CPrice;
            txtPrice.Text = Convert.ToString(Total);
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            Rock f4 = new Rock();
            f4.ShowDialog();

            txtRockPrice.Text = f4.RockPrice;
            double RPrice = Convert.ToDouble(this.txtRockPrice.Text);
            Total += RPrice;
            txtPrice.Text = Convert.ToString(Total);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Customer_Info f5 = new Customer_Info();
            f5.ShowDialog();

            lblFirst.Text = f5.FirstName;
            lblLast.Text = f5.LastName;
            lblAdd1.Text = f5.Address1;
            lblAdd2.Text = f5.Address2;
            lblCardType.Text = f5.CardType;
            lblCardNum.Text = f5.CardNum;
            lblCSC.Text = f5.CSC;
            lblDate.Text = f5.Date;
            lblEmail.Text = f5.Email;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
