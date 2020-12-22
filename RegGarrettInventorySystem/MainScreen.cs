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
            partDataGrid.ClearSelection();
            MessageBox.Show("selection cleared from MainScreenForm initilization");
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
            partDataGrid.MultiSelect = false;
            partDataGrid.ClearSelection();
            MessageBox.Show("selection should be cleared, from setUpMainScreenDGV");

            productDataGrid.Columns[0].HeaderText = "Product ID";
            productDataGrid.Columns[2].HeaderText = "Inventory";
            productDataGrid.RowHeadersVisible = false;
            productDataGrid.AllowUserToAddRows = false;
            productDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDataGrid.DefaultCellStyle.SelectionBackColor = Color.Brown;
            productDataGrid.AllowUserToResizeColumns = false;
            productDataGrid.AllowUserToResizeRows = false;
            productDataGrid.MultiSelect = false;
            //productDataGrid.ClearSelection();
        }

        //Part event handlers
        private void partDeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("part delete Button clicked");
        }

        private void partAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        private void partModifyButton_Click(object sender, EventArgs e)
        {
            if(partDataGrid.CurrentRow.DataBoundItem.GetType() == Inventory.Parts[0].GetType())
            {
                int partIndex = partDataGrid.CurrentCell.RowIndex;
                Inhouse selectPart = (Inhouse)partDataGrid.CurrentRow.DataBoundItem;
                new ModifyPartForm(selectPart, partIndex).ShowDialog();
            }
            else
            {
                int partIndex = partDataGrid.CurrentCell.RowIndex;
                Outsourced selectPart = (Outsourced)partDataGrid.CurrentRow.DataBoundItem;
                new ModifyPartForm(selectPart, partIndex).ShowDialog();
            }
            
            
        }


        //Product event handlers
        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("product delete Button clicked");
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
            this.Hide();
        }

        private void productModifyButton_Click(object sender, EventArgs e)
        {
            ModifyProductForm modifyProductForm = new ModifyProductForm();
            modifyProductForm.Show();
            this.Hide();
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

            partDataGrid.ClearSelection();
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

            productDataGrid.ClearSelection();
        }


        //Exit handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
