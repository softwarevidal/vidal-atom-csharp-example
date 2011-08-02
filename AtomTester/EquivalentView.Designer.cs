namespace AtomTester
{
    partial class EquivalentView
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 513);
            this.groupBox1.TabIndex = 56;
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
            this.productDataGridView.Size = new System.Drawing.Size(900, 450);
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
            this.numericUpDown2.Location = new System.Drawing.Point(577, 484);
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
            this.numericUpDown1.Location = new System.Drawing.Point(451, 484);
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
            this.productResultLabel.Location = new System.Drawing.Point(899, 494);
            this.productResultLabel.Name = "productResultLabel";
            this.productResultLabel.Size = new System.Drawing.Size(12, 13);
            this.productResultLabel.TabIndex = 12;
            this.productResultLabel.Text = "/";
            // 
            // productNextButton
            // 
            this.productNextButton.Location = new System.Drawing.Point(795, 484);
            this.productNextButton.Name = "productNextButton";
            this.productNextButton.Size = new System.Drawing.Size(75, 23);
            this.productNextButton.TabIndex = 11;
            this.productNextButton.Text = ">>";
            this.productNextButton.UseVisualStyleBackColor = true;
            this.productNextButton.Click += new System.EventHandler(this.productNextButton_Click);
            // 
            // productBackbutton
            // 
            this.productBackbutton.Location = new System.Drawing.Point(714, 484);
            this.productBackbutton.Name = "productBackbutton";
            this.productBackbutton.Size = new System.Drawing.Size(75, 23);
            this.productBackbutton.TabIndex = 10;
            this.productBackbutton.Text = "<<";
            this.productBackbutton.UseVisualStyleBackColor = true;
            this.productBackbutton.Click += new System.EventHandler(this.productBackbutton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(19, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 13);
            this.titleLabel.TabIndex = 57;
            this.titleLabel.Text = "label1";
            // 
            // EquivalentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 592);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "EquivalentView";
            this.Text = "EquivalentView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label titleLabel;
    }
}