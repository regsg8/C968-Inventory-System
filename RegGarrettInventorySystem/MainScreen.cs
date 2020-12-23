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
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
            setUpMainScreenDGV();
        }

        //Set up data grid
        public void setUpMainScreenDGV()
        {
            //Add data
            
           Inventory.populateMainScreenDGV();
           
           partDataGrid.DataSource = Inventory.Parts;
           productDataGrid.DataSource = Inventory.Products;

            //Format data
            partDataGrid.Columns[0].HeaderText = "Part ID";
            partDataGrid.Columns[2].HeaderText = "Inventory";
            partDataGrid.RowHeadersVisible = false;
            partDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            partDataGrid.AllowUserToResizeColumns = false;
            partDataGrid.AllowUserToResizeRows = false;
            partDataGrid.ReadOnly = true;
            partDataGrid.MultiSelect = false;

            productDataGrid.Columns[0].HeaderText = "Product ID";
            productDataGrid.Columns[2].HeaderText = "Inventory";
            productDataGrid.RowHeadersVisible = false;
            productDataGrid.AllowUserToAddRows = false;
            productDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDataGrid.DefaultCellStyle.SelectionBackColor = Color.Brown;
            productDataGrid.AllowUserToResizeColumns = false;
            productDataGrid.AllowUserToResizeRows = false;
            productDataGrid.ReadOnly = true;
            productDataGrid.MultiSelect = false;
        }
        
        //Part event handlers
        private void partDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this part?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int partID = int.Parse(partDataGrid.Rows[partDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Inventory.deletePart(partID);
            }
        }

        private void partAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        private void partModifyButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(partDataGrid.Rows[partDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (Inventory.lookupPart(partID).GetType() == Inventory.sampleInsource.GetType())
            {
                Inhouse selectPart = (Inhouse)Inventory.lookupPart(partID);
                new ModifyPartForm(selectPart).ShowDialog();
            }
            else
            {
                Outsourced selectPart = (Outsourced)Inventory.lookupPart(partID);
                new ModifyPartForm(selectPart).ShowDialog();
            }
        }


        //Product event handlers
        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int productID = int.Parse(productDataGrid.Rows[productDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Inventory.removeProduct(productID);
            }
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void productModifyButton_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(productDataGrid.Rows[productDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            new ModifyProductForm(Inventory.lookupProduct(productID)).ShowDialog();
        }


        //Search handlers
        private void partSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> searchResults = new BindingList<Part>();
            bool found = false;
            for (int i = 0; i < Inventory.Parts.Count; i++)
            {
                if (Inventory.Parts[i].Name.ToLower().Contains(partsSearch.Text.ToLower()))
                {
                    searchResults.Add(Inventory.Parts[i]);
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("No parts match your search");
                partDataGrid.DataSource = Inventory.Parts;
            }
            else partDataGrid.DataSource = searchResults;
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> searchResults = new BindingList<Product>();
            bool found = false;
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].Name.ToLower().Contains(productSearch.Text.ToLower()))
                {
                    searchResults.Add(Inventory.Products[i]);
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("No products match your search");
                productDataGrid.DataSource = Inventory.Products;
            }
            else productDataGrid.DataSource = searchResults;
        }


        //Exit handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
