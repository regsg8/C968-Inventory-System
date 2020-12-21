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

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }


        //Navigation handlers
        private void savePart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save delete Button clicked");
        }

        private void cancelPart_Click(object sender, EventArgs e)
        {
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
            this.Close();
        }


        //Class handlers
        private void inhouseRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {

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
