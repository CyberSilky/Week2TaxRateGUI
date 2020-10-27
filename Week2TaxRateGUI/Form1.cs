using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2TaxRateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            const double OVER_BUDGET_AMOUNT = 100;
            const double five_percent = .05;
            const double six_percent = .06;
            const double seven_percent = .07;
            const double eight_percent = .08;
            const double nine_percent = .09;

            int quantity = 0;
            double item_price = 0;
            double total_price = 0;

            quantity = Convert.ToInt32(txtQuantity.Text);
            item_price = Convert.ToDouble(txtPrice.Text);

            total_price = item_price * quantity;

            

            
        }
    }
}
