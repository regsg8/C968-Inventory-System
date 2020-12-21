
namespace RegGarrettInventorySystem
{
    partial class MainScreenForm
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
            this.partDataGrid = new System.Windows.Forms.DataGridView();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.partDeleteButton = new System.Windows.Forms.Button();
            this.partModifyButton = new System.Windows.Forms.Button();
            this.partAddButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productModifyButton = new System.Windows.Forms.Button();
            this.productAddButton = new System.Windows.Forms.Button();
            this.appLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.partsSearch = new System.Windows.Forms.TextBox();
            this.productSearch = new System.Windows.Forms.TextBox();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // partDataGrid
            // 
            this.partDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGrid.Location = new System.Drawing.Point(12, 110);
            this.partDataGrid.Name = "partDataGrid";
            this.partDataGrid.ReadOnly = true;
            this.partDataGrid.Size = new System.Drawing.Size(603, 209);
            this.partDataGrid.TabIndex = 0;
            // 
            // productDataGrid
            // 
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(630, 110);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.Size = new System.Drawing.Size(603, 209);
            this.productDataGrid.TabIndex = 1;
            // 
            // partDeleteButton
            // 
            this.partDeleteButton.Location = new System.Drawing.Point(565, 325);
            this.partDeleteButton.Name = "partDeleteButton";
            this.partDeleteButton.Size = new System.Drawing.Size(50, 23);
            this.partDeleteButton.TabIndex = 2;
            this.partDeleteButton.Text = "Delete";
            this.partDeleteButton.UseVisualStyleBackColor = true;
            this.partDeleteButton.Click += new System.EventHandler(this.partDeleteButton_Click);
            // 
            // partModifyButton
            // 
            this.partModifyButton.Location = new System.Drawing.Point(509, 325);
            this.partModifyButton.Name = "partModifyButton";
            this.partModifyButton.Size = new System.Drawing.Size(50, 23);
            this.partModifyButton.TabIndex = 1;
            this.partModifyButton.Text = "Modify";
            this.partModifyButton.UseVisualStyleBackColor = true;
            this.partModifyButton.Click += new System.EventHandler(this.partModifyButton_Click);
            // 
            // partAddButton
            // 
            this.partAddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.partAddButton.Location = new System.Drawing.Point(453, 325);
            this.partAddButton.Name = "partAddButton";
            this.partAddButton.Size = new System.Drawing.Size(50, 23);
            this.partAddButton.TabIndex = 0;
            this.partAddButton.Text = "Add";
            this.partAddButton.UseVisualStyleBackColor = false;
            this.partAddButton.Click += new System.EventHandler(this.partAddButton_Click);
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(1183, 325);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(50, 23);
            this.productDeleteButton.TabIndex = 2;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseCompatibleTextRendering = true;
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // productModifyButton
            // 
            this.productModifyButton.Location = new System.Drawing.Point(1127, 325);
            this.productModifyButton.Name = "productModifyButton";
            this.productModifyButton.Size = new System.Drawing.Size(50, 23);
            this.productModifyButton.TabIndex = 1;
            this.productModifyButton.Text = "Modify";
            this.productModifyButton.UseVisualStyleBackColor = true;
            this.productModifyButton.Click += new System.EventHandler(this.productModifyButton_Click);
            // 
            // productAddButton
            // 
            this.productAddButton.Location = new System.Drawing.Point(1071, 325);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(50, 23);
            this.productAddButton.TabIndex = 0;
            this.productAddButton.Text = "Add";
            this.productAddButton.UseVisualStyleBackColor = true;
            this.productAddButton.Click += new System.EventHandler(this.productAddButton_Click);
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.Location = new System.Drawing.Point(3, 13);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(229, 17);
            this.appLabel.TabIndex = 4;
            this.appLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(12, 91);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(36, 13);
            this.partsLabel.TabIndex = 5;
            this.partsLabel.Text = "Parts";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(630, 90);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(57, 13);
            this.productLabel.TabIndex = 6;
            this.productLabel.Text = "Products";
            // 
            // partsSearch
            // 
            this.partsSearch.Location = new System.Drawing.Point(450, 88);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(165, 20);
            this.partsSearch.TabIndex = 7;
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(1072, 87);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(161, 20);
            this.productSearch.TabIndex = 8;
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(394, 87);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(50, 21);
            this.partSearchButton.TabIndex = 9;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(1016, 87);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(50, 21);
            this.productSearchButton.TabIndex = 10;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1180, 406);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1244, 441);
            this.Controls.Add(this.productDeleteButton);
            this.Controls.Add(this.partDeleteButton);
            this.Controls.Add(this.productModifyButton);
            this.Controls.Add(this.productAddButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.partModifyButton);
            this.Controls.Add(this.partAddButton);
            this.Controls.Add(this.productSearchButton);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partsSearch);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.partDataGrid);
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partDataGrid;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Button partDeleteButton;
        private System.Windows.Forms.Button partModifyButton;
        private System.Windows.Forms.Button partAddButton;
        private System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.Button productModifyButton;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox partsSearch;
        private System.Windows.Forms.TextBox productSearch;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

