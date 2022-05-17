namespace My_Recepies
{
    partial class RecepiesForm
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
            this.txtBoxRecipeName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gBoxAdd = new System.Windows.Forms.GroupBox();
            this.txtBoxCountAdd = new System.Windows.Forms.TextBox();
            this.lblCountAdd = new System.Windows.Forms.Label();
            this.txtBoxNameAdd = new System.Windows.Forms.TextBox();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brnDeleteRow = new System.Windows.Forms.Button();
            this.txtBoxNameDelete = new System.Windows.Forms.TextBox();
            this.lblNameDelete = new System.Windows.Forms.Label();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.gBoxDelete = new System.Windows.Forms.GroupBox();
            this.lblRecipeKkal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxRecipeText = new System.Windows.Forms.TextBox();
            this.gBoxRecipeText = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gBoxDeleteRecipe = new System.Windows.Forms.GroupBox();
            this.txtBoxDeleteRecipe = new System.Windows.Forms.TextBox();
            this.lblDeleteRecipe = new System.Windows.Forms.Label();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.cBoxRecepies = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gBoxAdd.SuspendLayout();
            this.gBoxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gBoxRecipeText.SuspendLayout();
            this.gBoxDeleteRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxRecipeName
            // 
            this.txtBoxRecipeName.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRecipeName.Location = new System.Drawing.Point(249, 75);
            this.txtBoxRecipeName.Name = "txtBoxRecipeName";
            this.txtBoxRecipeName.Size = new System.Drawing.Size(341, 36);
            this.txtBoxRecipeName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(49, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(196, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название рецепта:";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIngredient.Location = new System.Drawing.Point(27, 160);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(461, 63);
            this.btnAddIngredient.TabIndex = 0;
            this.btnAddIngredient.Text = "Добавить ингредиент";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(748, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(298, 48);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Редактор рецептов";
            // 
            // gBoxAdd
            // 
            this.gBoxAdd.Controls.Add(this.txtBoxCountAdd);
            this.gBoxAdd.Controls.Add(this.lblCountAdd);
            this.gBoxAdd.Controls.Add(this.txtBoxNameAdd);
            this.gBoxAdd.Controls.Add(this.lblNameAdd);
            this.gBoxAdd.Controls.Add(this.btnAddIngredient);
            this.gBoxAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxAdd.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxAdd.Location = new System.Drawing.Point(794, 171);
            this.gBoxAdd.Name = "gBoxAdd";
            this.gBoxAdd.Size = new System.Drawing.Size(514, 245);
            this.gBoxAdd.TabIndex = 2;
            this.gBoxAdd.TabStop = false;
            this.gBoxAdd.Text = "Добавление ингредиента";
            // 
            // txtBoxCountAdd
            // 
            this.txtBoxCountAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxCountAdd.Location = new System.Drawing.Point(279, 107);
            this.txtBoxCountAdd.Name = "txtBoxCountAdd";
            this.txtBoxCountAdd.Size = new System.Drawing.Size(209, 36);
            this.txtBoxCountAdd.TabIndex = 2;
            // 
            // lblCountAdd
            // 
            this.lblCountAdd.AutoSize = true;
            this.lblCountAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountAdd.Location = new System.Drawing.Point(27, 107);
            this.lblCountAdd.Name = "lblCountAdd";
            this.lblCountAdd.Size = new System.Drawing.Size(254, 33);
            this.lblCountAdd.TabIndex = 1;
            this.lblCountAdd.Text = "Количество (в граммах):";
            // 
            // txtBoxNameAdd
            // 
            this.txtBoxNameAdd.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNameAdd.Location = new System.Drawing.Point(147, 54);
            this.txtBoxNameAdd.Name = "txtBoxNameAdd";
            this.txtBoxNameAdd.Size = new System.Drawing.Size(341, 36);
            this.txtBoxNameAdd.TabIndex = 2;
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
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngredients.Location = new System.Drawing.Point(49, 129);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(233, 33);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Список ингредиентов:";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название ингредиента";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.Width = 350;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Количество (в граммах)";
            this.ColumnCount.MinimumWidth = 6;
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCount.Width = 300;
            // 
            // brnDeleteRow
            // 
            this.brnDeleteRow.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnDeleteRow.Location = new System.Drawing.Point(27, 185);
            this.brnDeleteRow.Name = "brnDeleteRow";
            this.brnDeleteRow.Size = new System.Drawing.Size(461, 52);
            this.brnDeleteRow.TabIndex = 0;
            this.brnDeleteRow.Text = "Удалить выделенную строку";
            this.brnDeleteRow.UseVisualStyleBackColor = true;
            this.brnDeleteRow.Click += new System.EventHandler(this.brnDeleteRow_Click);
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
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteIngredient.Location = new System.Drawing.Point(27, 116);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(461, 52);
            this.btnDeleteIngredient.TabIndex = 0;
            this.btnDeleteIngredient.Text = "Удалить ингредиент";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // gBoxDelete
            // 
            this.gBoxDelete.Controls.Add(this.brnDeleteRow);
            this.gBoxDelete.Controls.Add(this.txtBoxNameDelete);
            this.gBoxDelete.Controls.Add(this.lblNameDelete);
            this.gBoxDelete.Controls.Add(this.btnDeleteIngredient);
            this.gBoxDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxDelete.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxDelete.Location = new System.Drawing.Point(794, 434);
            this.gBoxDelete.Name = "gBoxDelete";
            this.gBoxDelete.Size = new System.Drawing.Size(514, 262);
            this.gBoxDelete.TabIndex = 2;
            this.gBoxDelete.TabStop = false;
            this.gBoxDelete.Text = "Удаление ингредиента";
            // 
            // lblRecipeKkal
            // 
            this.lblRecipeKkal.AutoSize = true;
            this.lblRecipeKkal.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeKkal.Location = new System.Drawing.Point(794, 133);
            this.lblRecipeKkal.Name = "lblRecipeKkal";
            this.lblRecipeKkal.Size = new System.Drawing.Size(293, 33);
            this.lblRecipeKkal.TabIndex = 1;
            this.lblRecipeKkal.Text = "Общая калорийность: 0 ккал";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1711, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "S";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnCount});
            this.dataGridView.Location = new System.Drawing.Point(49, 179);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(705, 737);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Text = "dataGridView1";
            // 
            // txtBoxRecipeText
            // 
            this.txtBoxRecipeText.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRecipeText.Location = new System.Drawing.Point(19, 55);
            this.txtBoxRecipeText.Multiline = true;
            this.txtBoxRecipeText.Name = "txtBoxRecipeText";
            this.txtBoxRecipeText.Size = new System.Drawing.Size(439, 672);
            this.txtBoxRecipeText.TabIndex = 2;
            // 
            // gBoxRecipeText
            // 
            this.gBoxRecipeText.Controls.Add(this.txtBoxRecipeText);
            this.gBoxRecipeText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxRecipeText.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxRecipeText.Location = new System.Drawing.Point(1329, 171);
            this.gBoxRecipeText.Name = "gBoxRecipeText";
            this.gBoxRecipeText.Size = new System.Drawing.Size(474, 745);
            this.gBoxRecipeText.TabIndex = 2;
            this.gBoxRecipeText.TabStop = false;
            this.gBoxRecipeText.Text = "Описание рецепта";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1645, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gBoxDeleteRecipe
            // 
            this.gBoxDeleteRecipe.Controls.Add(this.txtBoxDeleteRecipe);
            this.gBoxDeleteRecipe.Controls.Add(this.lblDeleteRecipe);
            this.gBoxDeleteRecipe.Controls.Add(this.btnDeleteRecipe);
            this.gBoxDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxDeleteRecipe.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxDeleteRecipe.Location = new System.Drawing.Point(794, 718);
            this.gBoxDeleteRecipe.Name = "gBoxDeleteRecipe";
            this.gBoxDeleteRecipe.Size = new System.Drawing.Size(514, 198);
            this.gBoxDeleteRecipe.TabIndex = 2;
            this.gBoxDeleteRecipe.TabStop = false;
            this.gBoxDeleteRecipe.Text = "Удаление рецепта";
            // 
            // txtBoxDeleteRecipe
            // 
            this.txtBoxDeleteRecipe.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDeleteRecipe.Location = new System.Drawing.Point(147, 63);
            this.txtBoxDeleteRecipe.Name = "txtBoxDeleteRecipe";
            this.txtBoxDeleteRecipe.Size = new System.Drawing.Size(341, 36);
            this.txtBoxDeleteRecipe.TabIndex = 2;
            // 
            // lblDeleteRecipe
            // 
            this.lblDeleteRecipe.AutoSize = true;
            this.lblDeleteRecipe.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteRecipe.Location = new System.Drawing.Point(27, 63);
            this.lblDeleteRecipe.Name = "lblDeleteRecipe";
            this.lblDeleteRecipe.Size = new System.Drawing.Size(114, 33);
            this.lblDeleteRecipe.TabIndex = 1;
            this.lblDeleteRecipe.Text = "Название:";
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRecipe.Location = new System.Drawing.Point(27, 121);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(461, 52);
            this.btnDeleteRecipe.TabIndex = 0;
            this.btnDeleteRecipe.Text = "Удалить рецепт";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // cBoxRecepies
            // 
            this.cBoxRecepies.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxRecepies.FormattingEnabled = true;
            this.cBoxRecepies.Location = new System.Drawing.Point(1329, 125);
            this.cBoxRecepies.Name = "cBoxRecepies";
            this.cBoxRecepies.Size = new System.Drawing.Size(474, 41);
            this.cBoxRecepies.TabIndex = 4;
            this.cBoxRecepies.SelectedIndexChanged += new System.EventHandler(this.cBoxRecepies_SelectedIndexChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(1579, 41);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 60);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // RecepiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1815, 951);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cBoxRecepies);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gBoxRecipeText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRecipeKkal);
            this.Controls.Add(this.gBoxDeleteRecipe);
            this.Controls.Add(this.gBoxDelete);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.txtBoxRecipeName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gBoxAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecepiesForm";
            this.Text = " Список рецептов";
            this.Load += new System.EventHandler(this.RecepiesForm_Load);
            this.gBoxAdd.ResumeLayout(false);
            this.gBoxAdd.PerformLayout();
            this.gBoxDelete.ResumeLayout(false);
            this.gBoxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gBoxRecipeText.ResumeLayout(false);
            this.gBoxRecipeText.PerformLayout();
            this.gBoxDeleteRecipe.ResumeLayout(false);
            this.gBoxDeleteRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxRecipeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gBoxAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.TextBox txtBoxNameAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.TextBox txtBoxCountAdd;
        private System.Windows.Forms.Label lblCountAdd;
        private System.Windows.Forms.Button brnDeleteRow;
        private System.Windows.Forms.TextBox txtBoxNameDelete;
        private System.Windows.Forms.Label lblNameDelete;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.GroupBox gBoxDelete;
        private System.Windows.Forms.Label lblRecipeKkal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxRecipeText;
        private System.Windows.Forms.GroupBox gBoxRecipeText;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gBoxDeleteRecipe;
        private System.Windows.Forms.TextBox txtBoxDeleteRecipe;
        private System.Windows.Forms.Label lblDeleteRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.ComboBox cBoxRecepies;
        private System.Windows.Forms.Button btnHelp;
    }
}