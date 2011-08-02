namespace AtomTester
{
    partial class ProductsByMoleculeView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.BeCareful = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DispensationPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenericType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.productResultLabel = new System.Windows.Forms.Label();
            this.productNextButton = new System.Windows.Forms.Button();
            this.productBackbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productMolecAssociatedGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMolecAssociatedResult = new System.Windows.Forms.NumericUpDown();
            this.productMolecAssociatedPage = new System.Windows.Forms.NumericUpDown();
            this.productMolecAssociatedResultLabel = new System.Windows.Forms.Label();
            this.productMolecAssociatedNutton = new System.Windows.Forms.Button();
            this.productMolecAssociatedPreviousButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productMolecAssociatedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMolecAssociatedResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMolecAssociatedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productDataGridView);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.productResultLabel);
            this.groupBox1.Controls.Add(this.productNextButton);
            this.groupBox1.Controls.Add(this.productBackbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 188);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médicaments";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BeCareful,
            this.CompanyName,
            this.RefundRate,
            this.Liste,
            this.DispensationPlace,
            this.GenericType,
            this.MarketStatus});
            this.productDataGridView.Location = new System.Drawing.Point(10, 19);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(900, 125);
            this.productDataGridView.TabIndex = 17;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // BeCareful
            // 
            this.BeCareful.DataPropertyName = "BeCareful";
            this.BeCareful.HeaderText = "BeCareful";
            this.BeCareful.Name = "BeCareful";
            this.BeCareful.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // RefundRate
            // 
            this.RefundRate.DataPropertyName = "RefundRate";
            this.RefundRate.HeaderText = "RefundRate";
            this.RefundRate.Name = "RefundRate";
            this.RefundRate.ReadOnly = true;
            // 
            // Liste
            // 
            this.Liste.DataPropertyName = "Liste";
            this.Liste.HeaderText = "Liste";
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            // 
            // DispensationPlace
            // 
            this.DispensationPlace.DataPropertyName = "DispensationPlace";
            this.DispensationPlace.HeaderText = "DispensationPlace";
            this.DispensationPlace.Name = "DispensationPlace";
            this.DispensationPlace.ReadOnly = true;
            // 
            // GenericType
            // 
            this.GenericType.DataPropertyName = "GenericType";
            this.GenericType.HeaderText = "GenericType";
            this.GenericType.Name = "GenericType";
            this.GenericType.ReadOnly = true;
            // 
            // MarketStatus
            // 
            this.MarketStatus.DataPropertyName = "MarketStatus";
            this.MarketStatus.HeaderText = "MarketStatus";
            this.MarketStatus.Name = "MarketStatus";
            this.MarketStatus.ReadOnly = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(569, 150);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(443, 150);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productResultLabel
            // 
            this.productResultLabel.AutoSize = true;
            this.productResultLabel.Location = new System.Drawing.Point(891, 160);
            this.productResultLabel.Name = "productResultLabel";
            this.productResultLabel.Size = new System.Drawing.Size(12, 13);
            this.productResultLabel.TabIndex = 12;
            this.productResultLabel.Text = "/";
            // 
            // productNextButton
            // 
            this.productNextButton.Location = new System.Drawing.Point(787, 150);
            this.productNextButton.Name = "productNextButton";
            this.productNextButton.Size = new System.Drawing.Size(75, 23);
            this.productNextButton.TabIndex = 11;
            this.productNextButton.Text = ">>";
            this.productNextButton.UseVisualStyleBackColor = true;
            // 
            // productBackbutton
            // 
            this.productBackbutton.Location = new System.Drawing.Point(706, 150);
            this.productBackbutton.Name = "productBackbutton";
            this.productBackbutton.Size = new System.Drawing.Size(75, 23);
            this.productBackbutton.TabIndex = 10;
            this.productBackbutton.Text = "<<";
            this.productBackbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productMolecAssociatedGridView);
            this.groupBox2.Controls.Add(this.productMolecAssociatedResult);
            this.groupBox2.Controls.Add(this.productMolecAssociatedPage);
            this.groupBox2.Controls.Add(this.productMolecAssociatedResultLabel);
            this.groupBox2.Controls.Add(this.productMolecAssociatedNutton);
            this.groupBox2.Controls.Add(this.productMolecAssociatedPreviousButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 188);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Médicaments";
            // 
            // productMolecAssociatedGridView
            // 
            this.productMolecAssociatedGridView.AllowUserToDeleteRows = false;
            this.productMolecAssociatedGridView.AllowUserToOrderColumns = true;
            this.productMolecAssociatedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productMolecAssociatedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.productMolecAssociatedGridView.Location = new System.Drawing.Point(10, 19);
            this.productMolecAssociatedGridView.Name = "productMolecAssociatedGridView";
            this.productMolecAssociatedGridView.ReadOnly = true;
            this.productMolecAssociatedGridView.Size = new System.Drawing.Size(900, 125);
            this.productMolecAssociatedGridView.TabIndex = 17;
            this.productMolecAssociatedGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productMolecAssociatedGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BeCareful";
            this.dataGridViewTextBoxColumn1.HeaderText = "BeCareful";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RefundRate";
            this.dataGridViewTextBoxColumn3.HeaderText = "RefundRate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Liste";
            this.dataGridViewTextBoxColumn4.HeaderText = "Liste";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DispensationPlace";
            this.dataGridViewTextBoxColumn5.HeaderText = "DispensationPlace";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GenericType";
            this.dataGridViewTextBoxColumn6.HeaderText = "GenericType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MarketStatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "MarketStatus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // productMolecAssociatedResult
            // 
            this.productMolecAssociatedResult.Location = new System.Drawing.Point(569, 150);
            this.productMolecAssociatedResult.Name = "productMolecAssociatedResult";
            this.productMolecAssociatedResult.Size = new System.Drawing.Size(120, 20);
            this.productMolecAssociatedResult.TabIndex = 14;
            this.productMolecAssociatedResult.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // productMolecAssociatedPage
            // 
            this.productMolecAssociatedPage.Location = new System.Drawing.Point(443, 150);
            this.productMolecAssociatedPage.Name = "productMolecAssociatedPage";
            this.productMolecAssociatedPage.Size = new System.Drawing.Size(120, 20);
            this.productMolecAssociatedPage.TabIndex = 13;
            this.productMolecAssociatedPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productMolecAssociatedResultLabel
            // 
            this.productMolecAssociatedResultLabel.AutoSize = true;
            this.productMolecAssociatedResultLabel.Location = new System.Drawing.Point(891, 160);
            this.productMolecAssociatedResultLabel.Name = "productMolecAssociatedResultLabel";
            this.productMolecAssociatedResultLabel.Size = new System.Drawing.Size(12, 13);
            this.productMolecAssociatedResultLabel.TabIndex = 12;
            this.productMolecAssociatedResultLabel.Text = "/";
            // 
            // productMolecAssociatedNutton
            // 
            this.productMolecAssociatedNutton.Location = new System.Drawing.Point(787, 150);
            this.productMolecAssociatedNutton.Name = "productMolecAssociatedNutton";
            this.productMolecAssociatedNutton.Size = new System.Drawing.Size(75, 23);
            this.productMolecAssociatedNutton.TabIndex = 11;
            this.productMolecAssociatedNutton.Text = ">>";
            this.productMolecAssociatedNutton.UseVisualStyleBackColor = true;
            this.productMolecAssociatedNutton.Click += new System.EventHandler(this.productMolecAssociatedNutton_Click);
            // 
            // productMolecAssociatedPreviousButton
            // 
            this.productMolecAssociatedPreviousButton.Location = new System.Drawing.Point(706, 150);
            this.productMolecAssociatedPreviousButton.Name = "productMolecAssociatedPreviousButton";
            this.productMolecAssociatedPreviousButton.Size = new System.Drawing.Size(75, 23);
            this.productMolecAssociatedPreviousButton.TabIndex = 10;
            this.productMolecAssociatedPreviousButton.Text = "<<";
            this.productMolecAssociatedPreviousButton.UseVisualStyleBackColor = true;
            this.productMolecAssociatedPreviousButton.Click += new System.EventHandler(this.productMolecAssociatedPreviousButton_Click);
            // 
            // ProductsByMoleculeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductsByMoleculeForm";
            this.Text = "ProductsByMoleculeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productMolecAssociatedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMolecAssociatedResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMolecAssociatedPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeCareful;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DispensationPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenericType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketStatus;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label productResultLabel;
        private System.Windows.Forms.Button productNextButton;
        private System.Windows.Forms.Button productBackbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView productMolecAssociatedGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.NumericUpDown productMolecAssociatedResult;
        private System.Windows.Forms.NumericUpDown productMolecAssociatedPage;
        private System.Windows.Forms.Label productMolecAssociatedResultLabel;
        private System.Windows.Forms.Button productMolecAssociatedNutton;
        private System.Windows.Forms.Button productMolecAssociatedPreviousButton;
    }
}