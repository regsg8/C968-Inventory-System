
namespace RegGarrettInventorySystem
{
    partial class ModifyPartForm
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
            this.cancelPart = new System.Windows.Forms.Button();
            this.savePart = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.MaskedTextBox();
            this.minInput = new System.Windows.Forms.MaskedTextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.variableInput = new System.Windows.Forms.MaskedTextBox();
            this.maxInput = new System.Windows.Forms.MaskedTextBox();
            this.priceInput = new System.Windows.Forms.MaskedTextBox();
            this.inventoryInput = new System.Windows.Forms.MaskedTextBox();
            this.nameInput = new System.Windows.Forms.MaskedTextBox();
            this.variableLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelPart
            // 
            this.cancelPart.Location = new System.Drawing.Point(205, 259);
            this.cancelPart.Name = "cancelPart";
            this.cancelPart.Size = new System.Drawing.Size(75, 23);
            this.cancelPart.TabIndex = 34;
            this.cancelPart.Text = "Cancel";
            this.cancelPart.UseVisualStyleBackColor = true;
            this.cancelPart.Click += new System.EventHandler(this.cancelPart_Click);
            // 
            // savePart
            // 
            this.savePart.Location = new System.Drawing.Point(118, 260);
            this.savePart.Name = "savePart";
            this.savePart.Size = new System.Drawing.Size(75, 23);
            this.savePart.TabIndex = 33;
            this.savePart.Text = "Save";
            this.savePart.UseVisualStyleBackColor = true;
            this.savePart.Click += new System.EventHandler(this.savePart_Click);
            // 
            // idBox
            // 
            this.idBox.AllowPromptAsInput = false;
            this.idBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(126, 42);
            this.idBox.Mask = "000";
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(155, 20);
            this.idBox.TabIndex = 32;
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(230, 163);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(51, 20);
            this.minInput.TabIndex = 31;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(198, 170);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 30;
            this.minLabel.Text = "Min";
            // 
            // variableInput
            // 
            this.variableInput.Location = new System.Drawing.Point(126, 193);
            this.variableInput.Name = "variableInput";
            this.variableInput.Size = new System.Drawing.Size(155, 20);
            this.variableInput.TabIndex = 29;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(126, 163);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(52, 20);
            this.maxInput.TabIndex = 28;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(126, 133);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(155, 20);
            this.priceInput.TabIndex = 27;
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(126, 102);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(155, 20);
            this.inventoryInput.TabIndex = 26;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(126, 72);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(155, 20);
            this.nameInput.TabIndex = 25;
            // 
            // variableLabel
            // 
            this.variableLabel.Location = new System.Drawing.Point(40, 200);
            this.variableLabel.Name = "variableLabel";
            this.variableLabel.Size = new System.Drawing.Size(80, 13);
            this.variableLabel.TabIndex = 18;
            this.variableLabel.Text = "company name";
            this.variableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(93, 170);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 24;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(57, 140);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Price / Cost";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(69, 109);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 22;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(85, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(102, 49);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(201, 12);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadio.TabIndex = 19;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
            // 
            // inhouseRadio
            // 
            this.inhouseRadio.AutoSize = true;
            this.inhouseRadio.Location = new System.Drawing.Point(126, 12);
            this.inhouseRadio.Name = "inhouseRadio";
            this.inhouseRadio.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadio.TabIndex = 17;
            this.inhouseRadio.TabStop = true;
            this.inhouseRadio.Text = "In-House";
            this.inhouseRadio.UseVisualStyleBackColor = true;
            this.inhouseRadio.CheckedChanged += new System.EventHandler(this.inhouseRadio_CheckedChanged);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.cancelPart);
            this.Controls.Add(this.savePart);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.variableInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.variableLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.inhouseRadio);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelPart;
        private System.Windows.Forms.Button savePart;
        private System.Windows.Forms.MaskedTextBox idBox;
        private System.Windows.Forms.MaskedTextBox minInput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.MaskedTextBox variableInput;
        private System.Windows.Forms.MaskedTextBox maxInput;
        private System.Windows.Forms.MaskedTextBox priceInput;
        private System.Windows.Forms.MaskedTextBox inventoryInput;
        private System.Windows.Forms.MaskedTextBox nameInput;
        private System.Windows.Forms.Label variableLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.RadioButton inhouseRadio;
    }
}