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
    public partial class ModifyPartForm : Form
    {

        public ModifyPartForm(Inhouse inhouse)
        {
            InitializeComponent();
            inhouseRadio.Checked = true;
            variableLabel.Text = "Machine ID";
            idBox.Text = inhouse.PartID.ToString();
            nameInput.Text = inhouse.Name;
            inventoryInput.Text = inhouse.InStock.ToString();
            priceInput.Text = inhouse.Price.ToString();
            minInput.Text = inhouse.Min.ToString();
            maxInput.Text = inhouse.Max.ToString();
            variableInput.Text = inhouse.MachineID.ToString();
        }

        public ModifyPartForm(Outsourced outsourced)
        {
            InitializeComponent();
            outsourcedRadio.Checked = true;
            variableLabel.Text = "Company Name";
            idBox.Text = outsourced.PartID.ToString();
            nameInput.Text = outsourced.Name;
            inventoryInput.Text = outsourced.InStock.ToString();
            priceInput.Text = outsourced.Price.ToString();
            minInput.Text = outsourced.Min.ToString();
            maxInput.Text = outsourced.Max.ToString();
            variableInput.Text = outsourced.CompanyName;
        }


        private void savePart_Click(object sender, EventArgs e)
        {

            if (nameInput.Text == "")
            {
                MessageBox.Show("Please provide a name.");
            }
            else if (inventoryInput.Text == "")
            {
                MessageBox.Show("Please provide how many parts are currently in stock in the Inventory field.");
            }
            else if (priceInput.Text == "")
            {
                MessageBox.Show("Please provide a price for the part.");
            }
            else if (maxInput.Text == "")
            {
                MessageBox.Show("Please provide a maximum amount of units in the Max field.");
            }
            else if (minInput.Text == "")
            {
                MessageBox.Show("Please provide a minimum amount of units in the Min field.");
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
                    Inhouse newInhouse = new Inhouse(int.Parse(idBox.Text), nameInput.Text, int.Parse(inventoryInput.Text), decimal.Parse(priceInput.Text), int.Parse(minInput.Text), int.Parse(maxInput.Text), int.Parse(variableInput.Text));
                    Inventory.updatePart(newInhouse.PartID, newInhouse);
                    this.Close();
                }
                else 
                {
                    Outsourced newOutsourced = new Outsourced(int.Parse(idBox.Text), nameInput.Text, int.Parse(inventoryInput.Text), decimal.Parse(priceInput.Text), int.Parse(minInput.Text), int.Parse(maxInput.Text), variableInput.Text);
                    Inventory.updatePart(newOutsourced.PartID, newOutsourced);
                    this.Close();
                }
            }
        }

        private void cancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}
