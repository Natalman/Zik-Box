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
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }

        private void Country_Load(object sender, EventArgs e)
        {

        }
        private string Cprice = "";

        public string CountryPrice
        {
            get { return Cprice; }
            set { Cprice = value; }
        }

        private string[] Country80s =
            { "I can’t Stop Loving You \r\t Don Gibson \r\t $6.00","My Special Angel \r\t Jimmy Duncan \r\t $5.00",
            "Sixteen Tons \r\t Merle Travis \r\t $10.00", "Walk’ After Midnight \r\t Alan Block and Don Hecht \r\t $7.00" };

        private string[] Country90s =
            { "Border Affair \r\t Lee Clayton \r\t $10.00", "Cowboys and Daddys \r\t Bobby Bare \r\t $8.00",
            "I’ll Be Your Everything \r\t Percy Sledge \r\t $15.00", "Silk Purse \r\t Linda Ronstadt \r\t $10.00" };

        private string[] CountryTodays =
            {"Like a Arrow \r\t Blackberry Smoke \r\t $4.00","Pure and Simple \r\t Dolly Parton \r\t $10.00",
            "Ripcord \r\t Keith Urban \r\t $5.00","Traveller \r\t Chris Stapleton \r\t $15.00" };

        private void rdC80_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstCSummary, Country80s);
        }

        private void rdC90_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstCSummary, Country90s);
        }

        private void rdCToday_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstCSummary, CountryTodays);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdC80.Checked)
            {
                iflers.selection(lstCSummary, Country80s, lstCBought);
            }

            if (rdC90.Checked)
            {
                iflers.selection(lstCSummary, Country90s, lstCBought);
            }

            if (rdCToday.Checked)
            {
                iflers.selection(lstCSummary, CountryTodays, lstCBought);
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            iflers.PriceCheck(lstCBought, txtCPrice);
            CountryPrice = txtCPrice.Text;
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            iflers.ClearAll(lstCBought);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            iflers.delete(lstCBought);
        }
    }
}
