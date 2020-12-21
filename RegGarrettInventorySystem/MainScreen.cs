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
            Product loadProd1 = new Product(11, "Purple Bike", 12, 80, 1, 40);
            Inventory.Products.Add(loadProd1);
        }

        //Part event handlers
        private void partDeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("part delete Button clicked");
        }

        private void partAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
            this.Hide();
        }

        private void partModifyButton_Click(object sender, EventArgs e)
        {
            ModifyPartForm modifyPartForm = new ModifyPartForm();
            modifyPartForm.Show();
            MessageBox.Show($"{this.Name}");
            this.Hide();
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


        //Search event handlers
        private void partSearchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("part search Button clicked");
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("product search Button clicked");
        }


        //Exit event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
