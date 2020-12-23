using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegGarrettInventorySystem
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        //Navigation handlers
        private void savePart_Click(object sender, EventArgs e)
        {
            bool checkDigits(string s) => int.TryParse(s, out int i);
            bool invNum = checkDigits(inventoryInput.Text);
            bool maxNum = checkDigits(maxInput.Text);
            bool minNum = checkDigits(minInput.Text);
            bool priceNum = checkDigits(priceInput.Text);
            if (inhouseRadio.Checked && variableInput.Text != "")
            {
                bool machineNum = checkDigits(variableInput.Text);
                if (!machineNum)
                {
                    MessageBox.Show("Machine ID must be a number");
                }
            }
                if (nameInput.Text == "")
            {
                MessageBox.Show("Please provide a name for the new part in the Name field.");
            }
            else if (inventoryInput.Text == "")
            {
                MessageBox.Show("Please provide how many parts are currently in stock in the Inventory field.");
            }
            else if (priceInput.Text == "")
            {
                MessageBox.Show("Please provide a price for the new part.");
            }
            else if (maxInput.Text == "")
            {
                MessageBox.Show("Please provide a maximum amount of units in the Max field.");
            }
            else if (minInput.Text == "")
            {
                MessageBox.Show("Please provide a minimum amount of units in the Min field.");
            }
            else if (!invNum || !maxNum || !minNum || !priceNum)
            {
                MessageBox.Show("Inventory, Max, Min, and Price fields all must be numbers.");
            }
            else if (int.Parse(maxInput.Text) < int.Parse(minInput.Text))
            {
                MessageBox.Show("Maximum amount cannot be less than Minimum amount.");
            }
            else if (int.Parse(maxInput.Text) < int.Parse(inventoryInput.Text) || (int.Parse(minInput.Text) > int.Parse(inventoryInput.Text)))
            {
                MessageBox.Show("Inventory level must be between the Minimum and Maximum amounts.");
            }
            else if (inhouseRadio.Checked && variableInput.Text == "") 
            {
                MessageBox.Show("Please provide a Machine ID");
            }
            else if (outsourcedRadio.Checked && variableInput.Text == "")
            {
                MessageBox.Show("Please provide a company name");
            }
            else
            {
                if (inhouseRadio.Checked)
                {
                    int newID = (Inventory.Parts[Inventory.Parts.Count - 1].PartID + 1);
                    Inhouse newInhouse = new Inhouse(newID, nameInput.Text, int.Parse(inventoryInput.Text), decimal.Parse(priceInput.Text), int.Parse(minInput.Text), int.Parse(maxInput.Text), int.Parse(variableInput.Text));
                    Inventory.addPart(newInhouse);
                    this.Close();
                }
                else
                {
                    int newID = (Inventory.Parts[Inventory.Parts.Count - 1].PartID + 1);
                    Outsourced newOutsourced = new Outsourced(newID, nameInput.Text, int.Parse(inventoryInput.Text), decimal.Parse(priceInput.Text), int.Parse(minInput.Text), int.Parse(maxInput.Text), variableInput.Text);
                    Inventory.addPart(newOutsourced);
                    this.Close();
                }
            }
        }

        private void cancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Class handlers
        private void inhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (inhouseRadio.Checked)
            {
                variableLabel.Text = "Machine ID";
            }
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRadio.Checked)
            {
                variableLabel.Text = "Company Name";
            }
        }


        //Text input handlers
        private void nameInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void inventoryInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void priceInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void minInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maxInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void variableInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
