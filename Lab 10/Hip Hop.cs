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
    public partial class Hip_Hop : Form
    {
        public Hip_Hop()
        {
            InitializeComponent();
        }
       
        private void Hip_Hop_Load(object sender, EventArgs e)
        {

        }

        private string price = "";

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        private string[] hipHop80s =
            { "Paid in Full \r\t Eric B. & Rakim \r\t $10.00","Paul’s Boutique \r\t Beastie Boys \r\t $8.00",
            "Raising Hell \r\t Beastie Boys \r\t $15.00", "Three Feet High \r\n and Rising \r\t De La Soul \r\t $7.00" };

        private string[] hipHop90s =
            { "Illmatic \r\t Nas \r\t $20.00", "Ready to Die \r\t The Notorious \r\t $10.00",
            "The Chronic \r\t Dr. Dre \r\t $15.00" };

        private string[] hipHopTodays =
            {"1992 \r\t The Game \r\t $20.00","A Seat at the Table \r\t Solange \r\t $10.00",
            "Lemonade \r\t Beyonce \r\t $25.00","Views \r\t Drake \r\t $15.00" };

        private void button2_Click(object sender, EventArgs e)
        {
            iflers.delete(lstBought);
        }

        private void rdH80_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstSummary, hipHop80s);
        }

        private void rdH90_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstSummary, hipHop90s);
        }

        private void rdHToday_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstSummary, hipHopTodays);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdH80.Checked)
            {
                iflers.selection(lstSummary, hipHop80s, lstBought);
            }

            if (rdH90.Checked)
            {
                iflers.selection(lstSummary, hipHop90s, lstBought);
            }

            if (rdHToday.Checked)
            {
                iflers.selection(lstSummary, hipHopTodays, lstBought);
            }
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            iflers.PriceCheck(lstBought, txtTotal);
            Price = txtTotal.Text;
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            iflers.ClearAll(lstBought);
        }
    }
}
