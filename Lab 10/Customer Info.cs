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
    public partial class Customer_Info : Form
    {
        private string firstName = "";
        private string lastName = "";
        private string address1 = "";
        private string address2 = "";
        private string cardType = "";
        private string cardNum = "";
        private string csc = "";
        private string date = "";
        private string email = "";

        public string FirstName{get { return firstName; }set { firstName = value; }}
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Address1 { get { return address1; } set { address1 = value; } }
        public string Address2 { get { return address2; } set { address2 = value; } }
        public string CardType { get { return cardType; } set { cardType = value; } }
        public string CardNum { get { return cardNum; } set { cardNum = value; } }
        public string CSC { get { return csc; } set { csc = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Email { get { return email; } set { email = value; } }


        public Customer_Info()
        {
            InitializeComponent();
        }

        private void Customer_Info_Load(object sender, EventArgs e)
        {
            string[] cardType = { "Card Type", "Visa", "American Express", "Master Card" };
            iflers.MyBox(cboCardType, cardType);

            string[] Month = { "Month", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            iflers.MyBox(cboMonth, Month);

            int year = DateTime.Today.Year;
            int endYear = year + 10;
            cboYear.Items.Add("Year");
            while (year < endYear)
            {
                cboYear.Items.Add(year);
                year++;
            }
            cboYear.SelectedIndex = 0;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            FirstName = txtFirst.Text;
            LastName = txtLast.Text;
            Address1 = txtAdd1.Text;
            Address2 = txtAdd2.Text;
            CardType = cboCardType.Text;
            CardNum = txtCardNum.Text;
            CSC = txtCSC.Text;
            Date = cboMonth.Text + "/" + cboYear.Text;
            Email = txtEmail.Text;

            this.Hide();
        }
    }
}
