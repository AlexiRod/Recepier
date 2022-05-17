namespace My_Recepies
{
    partial class ProductsForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gBoxAdd = new System.Windows.Forms.GroupBox();
            this.txtBoxKkalAdd = new System.Windows.Forms.TextBox();
            this.txtBoxNameAdd = new System.Windows.Forms.TextBox();
            this.lblKkalAdd = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKkal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxNameDelete = new System.Windows.Forms.TextBox();
            this.lblNameDelete = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.gBoxDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(545, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(288, 48);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Список продуктов";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(27, 160);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(461, 63);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Добавить продукт";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gBoxAdd
            // 
            this.gBoxAdd.Controls.Add(this.txtBoxKkalAdd);
            this.gBoxAdd.Controls.Add(this.txtBoxNameAdd);
            this.gBoxAdd.Controls.Add(this.lblKkalAdd);
            this.gBoxAdd.Controls.Add(this.lblNameAdd);
            this.gBoxAdd.Controls.Add(this.btnAddProduct);
            this.gBoxAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxAdd.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxAdd.Location = new System.Drawing.Point(819, 94);
            this.gBoxAdd.Name = "gBoxAdd";
            this.gBoxAdd.Size = new System.Drawing.Size(514, 239);
            this.gBoxAdd.TabIndex = 2;
            this.gBoxAdd.TabStop = false;
            this.gBoxAdd.Text = "Добавление продукта";
            // 
            // txtBoxKkalAdd
            // 
            this.txtBoxKkalAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxKkalAdd.Location = new System.Drawing.Point(192, 100);
            this.txtBoxKkalAdd.Name = "txtBoxKkalAdd";
            this.txtBoxKkalAdd.Size = new System.Drawing.Size(296, 36);
            this.txtBoxKkalAdd.TabIndex = 2;
            // 
            // txtBoxNameAdd
            // 
            this.txtBoxNameAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNameAdd.Location = new System.Drawing.Point(147, 54);
            this.txtBoxNameAdd.Name = "txtBoxNameAdd";
            this.txtBoxNameAdd.Size = new System.Drawing.Size(341, 36);
            this.txtBoxNameAdd.TabIndex = 2;
            // 
            // lblKkalAdd
            // 
            this.lblKkalAdd.AutoSize = true;
            this.lblKkalAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKkalAdd.Location = new System.Drawing.Point(27, 100);
            this.lblKkalAdd.Name = "lblKkalAdd";
            this.lblKkalAdd.Size = new System.Drawing.Size(159, 33);
            this.lblKkalAdd.TabIndex = 1;
            this.lblKkalAdd.Text = "Калорийность:";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameAdd.Location = new System.Drawing.Point(27, 54);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(114, 33);
            this.lblNameAdd.TabIndex = 1;
            this.lblNameAdd.Text = "Название:";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название продукта";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.Width = 350;
            // 
            // ColumnKkal
            // 
            this.ColumnKkal.HeaderText = "Калорийность (ккал/100г)";
            this.ColumnKkal.MinimumWidth = 6;
            this.ColumnKkal.Name = "ColumnKkal";
            this.ColumnKkal.ReadOnly = true;
            this.ColumnKkal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnKkal.Width = 400;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название продукта";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Калорийность (ккал/100г)";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 340;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView.Location = new System.Drawing.Point(41, 105);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(762, 569);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Text = "dataGridView1";
            // 
            // txtBoxNameDelete
            // 
            this.txtBoxNameDelete.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNameDelete.Location = new System.Drawing.Point(147, 63);
            this.txtBoxNameDelete.Name = "txtBoxNameDelete";
            this.txtBoxNameDelete.Size = new System.Drawing.Size(341, 36);
            this.txtBoxNameDelete.TabIndex = 2;
            // 
            // lblNameDelete
            // 
            this.lblNameDelete.AutoSize = true;
            this.lblNameDelete.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameDelete.Location = new System.Drawing.Point(27, 63);
            this.lblNameDelete.Name = "lblNameDelete";
            this.lblNameDelete.Size = new System.Drawing.Size(114, 33);
            this.lblNameDelete.TabIndex = 1;
            this.lblNameDelete.Text = "Название:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.Location = new System.Drawing.Point(27, 116);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(461, 52);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Удалить продукт";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // gBoxDelete
            // 
            this.gBoxDelete.Controls.Add(this.btnDeleteRow);
            this.gBoxDelete.Controls.Add(this.txtBoxNameDelete);
            this.gBoxDelete.Controls.Add(this.lblNameDelete);
            this.gBoxDelete.Controls.Add(this.btnDeleteProduct);
            this.gBoxDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxDelete.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxDelete.Location = new System.Drawing.Point(819, 350);
            this.gBoxDelete.Name = "gBoxDelete";
            this.gBoxDelete.Size = new System.Drawing.Size(514, 258);
            this.gBoxDelete.TabIndex = 2;
            this.gBoxDelete.TabStop = false;
            this.gBoxDelete.Text = "Удаление продукта";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRow.Location = new System.Drawing.Point(27, 185);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(461, 52);
            this.btnDeleteRow.TabIndex = 0;
            this.btnDeleteRow.Text = "Удалить выделенную строку";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(1269, 32);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 60);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gBoxDelete);
            this.Controls.Add(this.gBoxAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductsForm";
            this.Text = "Список продуктов";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.gBoxAdd.ResumeLayout(false);
            this.gBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gBoxDelete.ResumeLayout(false);
            this.gBoxDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gBoxAdd;
        private System.Windows.Forms.TextBox txtBoxKkalAdd;
        private System.Windows.Forms.TextBox txtBoxNameAdd;
        private System.Windows.Forms.Label lblKkalAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKkal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtBoxNameDelete;
        private System.Windows.Forms.Label lblNameDelete;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox gBoxDelete;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnHelp;
    }
}