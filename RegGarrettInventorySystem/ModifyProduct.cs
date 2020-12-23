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
    public partial class ModifyProductForm : Form
    {
        private BindingList<Part> prodAssParts = new BindingList<Part>();
        private BindingList<Part> tempAllParts = new BindingList<Part>();
        private int mainID;
        public ModifyProductForm(Product product)
        {
            InitializeComponent();
            mainID = product.ProductID;
            idBox.Text = product.ProductID.ToString();
            nameInput.Text = product.Name;
            inventoryInput.Text = product.InStock.ToString();
            priceInput.Text = product.Price.ToString();
            minInput.Text = product.Min.ToString();
            maxInput.Text = product.Max.ToString();
            prodAssParts = product.AssociatedParts;
            setUpDataGrids();
        }

        private void formatDataGrid(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Part ID";
            dgv.Columns[2].HeaderText = "Inventory";
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
        }
        private void setUpDataGrids()
        {
            associatedPartsDataGrid.DataSource = prodAssParts;
            formatDataGrid(associatedPartsDataGrid);
            for (int i = 0; i < Inventory.Parts.Count; i++)
            {
                bool match = false;
                for (int j = 0; j < prodAssParts.Count; j++) 
                {
                    if(Inventory.Parts[i].PartID == prodAssParts[j].PartID)
                    {
                        match = true;
                    }
                }
                if (match != true)
                {
                    tempAllParts.Add(Inventory.Parts[i]);
                }
            }
            partsDataGrid.DataSource = tempAllParts;
            formatDataGrid(partsDataGrid);
        }
        private void partSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> searchResults = new BindingList<Part>();
            bool found = false;
            for (int i = 0; i < tempAllParts.Count; i++)
            {
                if (tempAllParts[i].Name.ToLower().Contains(partsSearch.Text.ToLower()))
                {
                    searchResults.Add(tempAllParts[i]);
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("No parts match your search");
                partsDataGrid.DataSource = tempAllParts;
            }
            else partsDataGrid.DataSource = searchResults;
        }

        private void partAddButton_Click(object sender, EventArgs e)
        {
            int partIndex = partsDataGrid.CurrentCell.RowIndex;
            if (partsDataGrid.CurrentRow.DataBoundItem.GetType() == Inventory.sampleInsource.GetType())
            {
                Inhouse selectPart = (Inhouse)partsDataGrid.CurrentRow.DataBoundItem;
                Inventory.lookupProduct(mainID).addAssociatedPart(selectPart);
                tempAllParts.RemoveAt(partIndex);
            }
            else
            {
                Outsourced selectPart = (Outsourced)partsDataGrid.CurrentRow.DataBoundItem;
                Inventory.lookupProduct(mainID).addAssociatedPart(selectPart);
                tempAllParts.RemoveAt(partIndex);
            }
        }

        private void removePart_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(associatedPartsDataGrid.Rows[associatedPartsDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (associatedPartsDataGrid.CurrentRow.DataBoundItem.GetType() == Inventory.sampleInsource.GetType())
            {
                Inhouse selectPart = (Inhouse)associatedPartsDataGrid.CurrentRow.DataBoundItem;
                tempAllParts.Add(selectPart);
                Inventory.lookupProduct(mainID).removeAssociatedPart(partID);
            }
            else
            {
                Outsourced selectPart = (Outsourced)associatedPartsDataGrid.CurrentRow.DataBoundItem;
                tempAllParts.Add(selectPart);
                Inventory.lookupProduct(mainID).removeAssociatedPart(partID);
            }
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                MessageBox.Show("Please provide a name for the new product in the Name field.");
            }
            else if (inventoryInput.Text == "")
            {
                MessageBox.Show("Please provide how many products are currently in stock in the Inventory field.");
            }
            else if (priceInput.Text == "")
            {
                MessageBox.Show("Please provide a price for the new product.");
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
            else
            {
                this.Hide();

                Product updatedProduct = new Product(int.Parse(idBox.Text), nameInput.Text, int.Parse(inventoryInput.Text), decimal.Parse(priceInput.Text), int.Parse(minInput.Text), int.Parse(maxInput.Text), prodAssParts);
                Inventory.updateProduct(updatedProduct.ProductID, updatedProduct);
                this.Close();
            }
        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
