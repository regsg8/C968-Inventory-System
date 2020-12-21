
namespace RegGarrettInventorySystem
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idBox = new System.Windows.Forms.MaskedTextBox();
            this.minInput = new System.Windows.Forms.MaskedTextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxInput = new System.Windows.Forms.MaskedTextBox();
            this.priceInput = new System.Windows.Forms.MaskedTextBox();
            this.inventoryInput = new System.Windows.Forms.MaskedTextBox();
            this.nameInput = new System.Windows.Forms.MaskedTextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.cancelPart = new System.Windows.Forms.Button();
            this.savePart = new System.Windows.Forms.Button();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.partsSearch = new System.Windows.Forms.TextBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partDataGrid = new System.Windows.Forms.DataGridView();
            this.partAddButton = new System.Windows.Forms.Button();
            this.removePart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.AllowPromptAsInput = false;
            this.idBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(83, 122);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(155, 20);
            this.idBox.TabIndex = 44;
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(187, 243);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(51, 20);
            this.minInput.TabIndex = 43;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(155, 250);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 42;
            this.minLabel.Text = "Min";
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(83, 243);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(52, 20);
            this.maxInput.TabIndex = 41;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(83, 213);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(155, 20);
            this.priceInput.TabIndex = 40;
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(83, 182);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(155, 20);
            this.inventoryInput.TabIndex = 39;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(83, 152);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(155, 20);
            this.nameInput.TabIndex = 38;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(50, 250);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 37;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(14, 220);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 36;
            this.priceLabel.Text = "Price / Cost";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(26, 189);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 35;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 159);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(59, 129);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 33;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelPart
            // 
            this.cancelPart.Location = new System.Drawing.Point(163, 388);
            this.cancelPart.Name = "cancelPart";
            this.cancelPart.Size = new System.Drawing.Size(75, 23);
            this.cancelPart.TabIndex = 46;
            this.cancelPart.Text = "Cancel";
            this.cancelPart.UseVisualStyleBackColor = true;
            // 
            // savePart
            // 
            this.savePart.Location = new System.Drawing.Point(76, 389);
            this.savePart.Name = "savePart";
            this.savePart.Size = new System.Drawing.Size(75, 23);
            this.savePart.TabIndex = 45;
            this.savePart.Text = "Save";
            this.savePart.UseVisualStyleBackColor = true;
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(424, 11);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(50, 21);
            this.partSearchButton.TabIndex = 50;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            // 
            // partsSearch
            // 
            this.partsSearch.Location = new System.Drawing.Point(480, 12);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(165, 20);
            this.partsSearch.TabIndex = 49;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(265, 16);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(115, 13);
            this.partsLabel.TabIndex = 48;
            this.partsLabel.Text = "All Candidate Parts";
            // 
            // partDataGrid
            // 
            this.partDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGrid.Location = new System.Drawing.Point(265, 35);
            this.partDataGrid.Name = "partDataGrid";
            this.partDataGrid.Size = new System.Drawing.Size(380, 141);
            this.partDataGrid.TabIndex = 47;
            // 
            // partAddButton
            // 
            this.partAddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.partAddButton.Location = new System.Drawing.Point(595, 182);
            this.partAddButton.Name = "partAddButton";
            this.partAddButton.Size = new System.Drawing.Size(50, 23);
            this.partAddButton.TabIndex = 51;
            this.partAddButton.Text = "Add";
            this.partAddButton.UseVisualStyleBackColor = false;
            // 
            // removePart
            // 
            this.removePart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.removePart.Location = new System.Drawing.Point(585, 358);
            this.removePart.Name = "removePart";
            this.removePart.Size = new System.Drawing.Size(60, 23);
            this.removePart.TabIndex = 56;
            this.removePart.Text = "Remove";
            this.removePart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Associated Parts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 141);
            this.dataGridView1.TabIndex = 52;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.removePart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.partAddButton);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.partsSearch);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.partDataGrid);
            this.Controls.Add(this.cancelPart);
            this.Controls.Add(this.savePart);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox idBox;
        private System.Windows.Forms.MaskedTextBox minInput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.MaskedTextBox maxInput;
        private System.Windows.Forms.MaskedTextBox priceInput;
        private System.Windows.Forms.MaskedTextBox inventoryInput;
        private System.Windows.Forms.MaskedTextBox nameInput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button cancelPart;
        private System.Windows.Forms.Button savePart;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.TextBox partsSearch;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.DataGridView partDataGrid;
        private System.Windows.Forms.Button partAddButton;
        private System.Windows.Forms.Button removePart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}