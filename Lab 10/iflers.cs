using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    class iflers
    {
        public static void Displayer(ListBox text, string [] Displays )
        {
            text.Items.Clear();
            text.Items.AddRange (Displays);
        }
       
        public static void selection( ListBox selectZiK, string [] ZikInfo, 
            ListBox Summary)
        {
            for(int n = 0; n < ZikInfo.Length; n++)
            {
                if (selectZiK.SelectedIndex == n)
                {
                    Summary.Items.Add(Convert.ToString(ZikInfo[n]));
                }
            } 
        }
        public static void PriceCheck (ListBox lstPrice, TextBox txtPrice)
        {
            string[] PriceArray = new string[lstPrice.Items.Count];
            List<double> PriceNum = new List<double>();
            Double sum = 0.0;
            for (int m = 0; m <lstPrice.Items.Count; m++)
            {
                PriceArray[m] = lstPrice.Items[m].ToString();
            }

            for(int n = 0; n < PriceArray.Length; n++)
            {
                int PriceIndex = PriceArray[n].IndexOf("$") + 1;
                PriceNum.Add(Convert.ToDouble(PriceArray[n].Substring(PriceIndex)));
            }
            foreach(double num in PriceNum)
            {
                sum += num;
            }
            txtPrice.Text = Convert.ToString(sum);
        }
        public static void delete (ListBox lstSelected)
        {
            if(lstSelected.SelectedIndex != -1)
            {
                lstSelected.Items.RemoveAt(lstSelected.SelectedIndex);
            }
            else
            {
                MessageBox.Show("please select Item to be delected");
            }
        }
        public static void ClearAll(ListBox lstClear)
        {
            lstClear.Items.Clear();
        }

        public static void MyBox(ComboBox ItemContain, string [] ArrayContain)
        {
            foreach (string Item in ArrayContain)
                ItemContain.Items.Add(Item);
            ItemContain.SelectedIndex = 0;
        }
    }
}
