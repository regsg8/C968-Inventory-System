
namespace RegGarrettInventorySystem
{
    partial class AddPartForm
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
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.variableLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.MaskedTextBox();
            this.inventoryInput = new System.Windows.Forms.MaskedTextBox();
            this.priceInput = new System.Windows.Forms.MaskedTextBox();
            this.maxInput = new System.Windows.Forms.MaskedTextBox();
            this.variableInput = new System.Windows.Forms.MaskedTextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minInput = new System.Windows.Forms.MaskedTextBox();
            this.idBox = new System.Windows.Forms.MaskedTextBox();
            this.savePart = new System.Windows.Forms.Button();
            this.cancelPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inhouseRadio
            // 
            this.inhouseRadio.AutoSize = true;
            this.inhouseRadio.Location = new System.Drawing.Point(126, 12);
            this.inhouseRadio.Name = "inhouseRadio";
            this.inhouseRadio.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadio.TabIndex = 0;
            this.inhouseRadio.TabStop = true;
            this.inhouseRadio.Text = "In-House";
            this.inhouseRadio.UseVisualStyleBackColor = true;
            this.inhouseRadio.CheckedChanged += new System.EventHandler(this.inhouseRadio_CheckedChanged);
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(201, 12);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadio.TabIndex = 1;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(102, 49);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(85, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(69, 109);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 4;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(57, 140);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price / Cost";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(93, 170);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 6;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // variableLabel
            // 
            this.variableLabel.Location = new System.Drawing.Point(30, 200);
            this.variableLabel.Name = "variableLabel";
            this.variableLabel.Size = new System.Drawing.Size(90, 13);
            this.variableLabel.TabIndex = 0;
            this.variableLabel.Text = "Machine ID";
            this.variableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(126, 72);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(155, 20);
            this.nameInput.TabIndex = 7;
            this.nameInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nameInput_MaskInputRejected);
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(126, 102);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(155, 20);
            this.inventoryInput.TabIndex = 8;
            this.inventoryInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inventoryInput_MaskInputRejected);
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(126, 133);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(155, 20);
            this.priceInput.TabIndex = 9;
            this.priceInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.priceInput_MaskInputRejected);
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(126, 163);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(52, 20);
            this.maxInput.TabIndex = 10;
            this.maxInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maxInput_MaskInputRejected);
            // 
            // variableInput
            // 
            this.variableInput.Location = new System.Drawing.Point(126, 193);
            this.variableInput.Name = "variableInput";
            this.variableInput.Size = new System.Drawing.Size(155, 20);
            this.variableInput.TabIndex = 11;
            this.variableInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.variableInput_MaskInputRejected);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(198, 170);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Min";
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(230, 163);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(51, 20);
            this.minInput.TabIndex = 13;
            this.minInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.minInput_MaskInputRejected);
            // 
            // idBox
            // 
            this.idBox.AllowPromptAsInput = false;
            this.idBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(126, 42);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(155, 20);
            this.idBox.TabIndex = 14;
            // 
            // savePart
            // 
            this.savePart.Location = new System.Drawing.Point(118, 260);
            this.savePart.Name = "savePart";
            this.savePart.Size = new System.Drawing.Size(75, 23);
            this.savePart.TabIndex = 15;
            this.savePart.Text = "Save";
            this.savePart.UseVisualStyleBackColor = true;
            this.savePart.Click += new System.EventHandler(this.savePart_Click);
            // 
            // cancelPart
            // 
            this.cancelPart.Location = new System.Drawing.Point(205, 259);
            this.cancelPart.Name = "cancelPart";
            this.cancelPart.Size = new System.Drawing.Size(75, 23);
            this.cancelPart.TabIndex = 16;
            this.cancelPart.Text = "Cancel";
            this.cancelPart.UseVisualStyleBackColor = true;
            this.cancelPart.Click += new System.EventHandler(this.cancelPart_Click);
            // 
            // AddPartForm
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
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inhouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label variableLabel;
        private System.Windows.Forms.MaskedTextBox nameInput;
        private System.Windows.Forms.MaskedTextBox inventoryInput;
        private System.Windows.Forms.MaskedTextBox priceInput;
        private System.Windows.Forms.MaskedTextBox maxInput;
        private System.Windows.Forms.MaskedTextBox variableInput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.MaskedTextBox minInput;
        private System.Windows.Forms.MaskedTextBox idBox;
        private System.Windows.Forms.Button savePart;
        private System.Windows.Forms.Button cancelPart;
    }
}