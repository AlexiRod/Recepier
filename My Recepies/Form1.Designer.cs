namespace My_Recepies
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProductsList = new System.Windows.Forms.Button();
            this.btnRecepiesList = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtBoxProducts = new System.Windows.Forms.TextBox();
            this.btnProductsConfirm = new System.Windows.Forms.Button();
            this.lblRecepies = new System.Windows.Forms.Label();
            this.txtBoxRecepies = new System.Windows.Forms.TextBox();
            this.btnRecepiesConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductsList
            // 
            this.btnProductsList.Enabled = false;
            this.btnProductsList.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductsList.Location = new System.Drawing.Point(91, 269);
            this.btnProductsList.Name = "btnProductsList";
            this.btnProductsList.Size = new System.Drawing.Size(387, 109);
            this.btnProductsList.TabIndex = 0;
            this.btnProductsList.Text = "К списку продуктов";
            this.btnProductsList.UseVisualStyleBackColor = true;
            this.btnProductsList.Click += new System.EventHandler(this.btnProductsList_Click);
            // 
            // btnRecepiesList
            // 
            this.btnRecepiesList.Enabled = false;
            this.btnRecepiesList.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecepiesList.Location = new System.Drawing.Point(527, 269);
            this.btnRecepiesList.Name = "btnRecepiesList";
            this.btnRecepiesList.Size = new System.Drawing.Size(387, 109);
            this.btnRecepiesList.TabIndex = 0;
            this.btnRecepiesList.Text = "К списку рецептов";
            this.btnRecepiesList.UseVisualStyleBackColor = true;
            this.btnRecepiesList.Click += new System.EventHandler(this.btnRecepiesList_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(181, 47);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(576, 26);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Укажите путь к файлу с продуктам (например, \"D:/Recepies/products.xml\")";
            // 
            // txtBoxProducts
            // 
            this.txtBoxProducts.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxProducts.Location = new System.Drawing.Point(181, 87);
            this.txtBoxProducts.Name = "txtBoxProducts";
            this.txtBoxProducts.Size = new System.Drawing.Size(416, 36);
            this.txtBoxProducts.TabIndex = 2;
            // 
            // btnProductsConfirm
            // 
            this.btnProductsConfirm.Location = new System.Drawing.Point(603, 87);
            this.btnProductsConfirm.Name = "btnProductsConfirm";
            this.btnProductsConfirm.Size = new System.Drawing.Size(154, 36);
            this.btnProductsConfirm.TabIndex = 3;
            this.btnProductsConfirm.Text = "Подтвердить";
            this.btnProductsConfirm.UseVisualStyleBackColor = true;
            this.btnProductsConfirm.Click += new System.EventHandler(this.btnProductsConfirm_Click);
            // 
            // lblRecepies
            // 
            this.lblRecepies.AutoSize = true;
            this.lblRecepies.Location = new System.Drawing.Point(181, 140);
            this.lblRecepies.Name = "lblRecepies";
            this.lblRecepies.Size = new System.Drawing.Size(573, 26);
            this.lblRecepies.TabIndex = 1;
            this.lblRecepies.Text = "Укажите путь к файлу с рецептами (например, \"D:/Recepies/recepies.xml\")";
            // 
            // txtBoxRecepies
            // 
            this.txtBoxRecepies.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRecepies.Location = new System.Drawing.Point(181, 180);
            this.txtBoxRecepies.Name = "txtBoxRecepies";
            this.txtBoxRecepies.Size = new System.Drawing.Size(416, 36);
            this.txtBoxRecepies.TabIndex = 2;
            // 
            // btnRecepiesConfirm
            // 
            this.btnRecepiesConfirm.Location = new System.Drawing.Point(603, 180);
            this.btnRecepiesConfirm.Name = "btnRecepiesConfirm";
            this.btnRecepiesConfirm.Size = new System.Drawing.Size(154, 36);
            this.btnRecepiesConfirm.TabIndex = 3;
            this.btnRecepiesConfirm.Text = "Подтвердить";
            this.btnRecepiesConfirm.UseVisualStyleBackColor = true;
            this.btnRecepiesConfirm.Click += new System.EventHandler(this.btnRecepiesConfirm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1003, 409);
            this.Controls.Add(this.btnRecepiesConfirm);
            this.Controls.Add(this.txtBoxRecepies);
            this.Controls.Add(this.lblRecepies);
            this.Controls.Add(this.btnProductsConfirm);
            this.Controls.Add(this.txtBoxProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnRecepiesList);
            this.Controls.Add(this.btnProductsList);
            this.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Мои рецепты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductsList;
        private System.Windows.Forms.Button btnRecepiesList;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtBoxProducts;
        private System.Windows.Forms.Button btnProductsConfirm;
        private System.Windows.Forms.Label lblRecepies;
        private System.Windows.Forms.TextBox txtBoxRecepies;
        private System.Windows.Forms.Button btnRecepiesConfirm;
    }
}

