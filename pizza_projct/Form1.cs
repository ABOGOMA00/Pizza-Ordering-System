using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_projct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbSize_Click(object sender, EventArgs e)
        {
            
          
          
        }

        private void rdSmaal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSmaal.Checked)
            {
                lbSize.Text = "Small";
            }
            lblPrice.Text = Price().ToString();

        }

        private void rdmeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmeduim.Checked)
            {
                lbSize.Text = "Meduim";
            }
            lblPrice.Text = Price().ToString();
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            if(rdLarge.Checked)
            {
                lbSize.Text = "Large";
            }
            lblPrice.Text = Price().ToString();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThinCrust.Checked)
            {
                lbCrustType.Text = "Thin";
                
            }
        }

        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThinkCrust.Checked)
            {
                lbCrustType.Text = "Think";

            }
            lblPrice.Text = Price().ToString();
        }

        private void rdEatin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEatin.Checked)
            {
                lbWhereToEat.Text = "Eat IN";
            }
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTakeOut.Checked)
            {
                lbWhereToEat.Text = "Take Out";
            }
        }

        private void chkxtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblPrice.Text = Price().ToString();
        }
        private void UpdateToppings()
        {
            lbToppings.Text = "";

            if (chkxtraCheese.Checked)
            {
                lbToppings.Text += "Extracheese,";
            }
            if (chkMashroum.Checked)
            {
                lbToppings.Text += "Mashroum,";
            }
            if (chkOlives.Checked)
            {
                lbToppings.Text += "Olives,";

            }
            if (chkOnion.Checked)
            {
                lbToppings.Text += "Onion,\n";
            }
            if (chkTomatos.Checked)
            {
                lbToppings.Text += "Tomatos,";
            }
            if (chkGreenPappers.Checked)
            {
                lbToppings.Text += "Green Pappers,";
            }
        }

        private void chkMashroum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblPrice.Text = Price().ToString();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblPrice.Text = Price().ToString();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblPrice.Text = Price().ToString();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblPrice.Text = Price().ToString();
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblPrice.Text = Price().ToString();
        }
        private int Price()
        {
            int salary = 0;

            if (rdSmaal.Checked)
            {
                salary = 30;
            }
            else if (rdmeduim.Checked)
            {
                salary = 50;
            }
            else if (rdLarge.Checked)
            {
                salary = 75;
            }
            if (chkGreenPappers.Checked)
            {
                salary += 5;
            }
            if (chkMashroum.Checked)
            {
                salary += 5;
            }
            if (chkOlives.Checked)
            {
                salary += 5;
            }
            if (chkOnion.Checked)
            {
                salary += 5;
            }
            if (chkTomatos.Checked)
            {
                salary += 5;
            }
            if (chkxtraCheese.Checked)
            {
                salary += 5;
            }
            if (rdThinkCrust.Checked)
            {
                salary += 10;

            }
            return salary;
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to confirm your order?","Confirm Order"
                ,MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Order Confirmed!");

                foreach (Control control in groupBox1.Controls)
                {
                    control.Enabled = false;
                }

                foreach (Control control in groupBox2.Controls)
                {
                    control.Enabled = false;
                }

                foreach (Control control in groupBox3.Controls)
                {
                    control.Enabled = false;
                }

                foreach (Control control in groupBox4.Controls)
                {
                    control.Enabled = false;
                }
            }
           

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ResetControls(this);

            lbToppings.Text = "No Toppings";
            lbSize.Text = "";
            lbCrustType.Text = "";
            lbWhereToEat.Text = "";
            lblPrice.Text = "0";
        }

        private void ResetControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.HasChildren)
                {
                    ResetControls(control);
                }

                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }

                control.Enabled = true;
            }
        }

    }
}
