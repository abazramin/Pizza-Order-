using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_project
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }


        void UpdateTotalPrice()
        {
            lbPriceSlected.Text = "$" + CalculateTotalPrice().ToString();
        }

        float GetSlectedSizePrice()
        {
            if (rdSmall.Checked)
            {
                return Convert.ToSingle( rdSmall.Tag );

            } else if (rdMeduim.Checked)
            {
                return Convert.ToSingle(rdMeduim.Tag);
            }
            else
            {
                return Convert.ToSingle(rdLarg.Tag);
            }
        }

        float GetSlectedThinkPrice()
        {
            if (rdThinkCrust.Checked)
            {
                return Convert.ToSingle(rdThinkCrust.Tag);

            } else if (rdThinCurst.Checked)
            {
                return Convert.ToSingle(rdThinCurst.Tag);
            }
            else
            {
                return 0;
            }
        }

        float GetSlectedToppings()
        {
            float ToppingsTotalPrice =  0 ;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice  = Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkGreenPeppers.Checked) 
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
                
            }


            return ToppingsTotalPrice;
        }

        float CalculateTotalPrice() {

            return GetSlectedSizePrice() + GetSlectedToppings() +GetSlectedThinkPrice();
        }
        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rdSmall.Checked)
            {
                lbSizeSelcted.Text = "Small";
                return;
            }

            if (rdMeduim.Checked)
            {
                lbSizeSelcted.Text = "Meduim";
                return;
            }

            if (rdLarg.Checked)
            {
                lbSizeSelcted.Text = "Larg";
                return;
            }

            

        }

        void UpdateThink()
        {
            UpdateTotalPrice();
            if (rdThinCurst.Checked)
            {
                lbCusrtSelect.Text = "Thin Curst";
            }

            if (rdThinkCrust.Checked)
            {
                lbCusrtSelect.Text = "Think Curst";
            }
        }

        void UpdateThing()
        {


            UpdateSize();

            string Toppins = " ";

             if (chkExtraChees.Checked)
             {
                Toppins = " Extra Chees";
             }

            if (chkMushrooms.Checked)
            {
                Toppins += ", Mushrooms";
            }

            if (chkGreenPeppers.Checked)
            {
                Toppins += ", Grren Peppers";
            }

            if (chkOlives.Checked)
            {
                Toppins += ", Oilves";
            }

            if (chkOnion.Checked) {
                Toppins += ", Onion";
            }

            if(chkTomatoes.Checked)
            {
                Toppins += ", Tomatoes ";
            }

            if (Toppins.StartsWith(","))
            {
                Toppins = Toppins.Substring(1, Toppins.Length - 1).Trim();
            }


            if (Toppins == "")
            {
                Toppins = " Not One Selected";
            } else
            {
                lbSelectToppings.Text =  Toppins;
            }
        }
        
        private void OrderDone()
        {
            if (MessageBox.Show("Are You Confirm", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order Done Sccessfully", "Result", MessageBoxButtons.OK,  MessageBoxIcon.Information);
                gCurstType.Enabled = false;
                gSize.Enabled = false;
                gWhereEat.Enabled = false;
                gToppings.Enabled = false;
            }
        }
        
        private void RestForm()
        {
            gCurstType.Enabled = true;
            gSize.Enabled = true;
            gWhereEat.Enabled = true;
            gToppings.Enabled = true;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            OrderDone();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RestForm();
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdThinCurst_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThink();
        }

        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThink();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThing();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThing();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThing();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThing();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThing();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateThing();
        }
    }
}
