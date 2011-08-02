namespace AtomTester
{
    partial class PackDetailView
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
            this.components = new System.ComponentModel.Container();
            this.libelleTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.monographWebBrowser = new System.Windows.Forms.WebBrowser();
            this.saumonTreeView = new System.Windows.Forms.TreeView();
            this.lpprDataGridView = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcketLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lpprDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpprBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libelleTextBox
            // 
            this.libelleTextBox.Location = new System.Drawing.Point(24, 27);
            this.libelleTextBox.Name = "libelleTextBox";
            this.libelleTextBox.Size = new System.Drawing.Size(312, 20);
            this.libelleTextBox.TabIndex = 0;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(606, 27);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(312, 20);
            this.companyTextBox.TabIndex = 1;
            // 
            // monographWebBrowser
            // 
            this.monographWebBrowser.Location = new System.Drawing.Point(12, 320);
            this.monographWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.monographWebBrowser.Name = "monographWebBrowser";
            this.monographWebBrowser.Size = new System.Drawing.Size(916, 506);
            this.monographWebBrowser.TabIndex = 2;
            // 
            // saumonTreeView
            // 
            this.saumonTreeView.Location = new System.Drawing.Point(24, 100);
            this.saumonTreeView.Name = "saumonTreeView";
            this.saumonTreeView.Size = new System.Drawing.Size(436, 192);
            this.saumonTreeView.TabIndex = 3;
            // 
            // lpprDataGridView
            // 
            this.lpprDataGridView.AutoGenerateColumns = false;
            this.lpprDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lpprDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.refundBaseDataGridViewTextBoxColumn,
            this.coefDataGridViewTextBoxColumn,
            this.actCodeDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn});
            this.lpprDataGridView.DataSource = this.lpprBindingSource;
            this.lpprDataGridView.Location = new System.Drawing.Point(483, 101);
            this.lpprDataGridView.Name = "lpprDataGridView";
            this.lpprDataGridView.ReadOnly = true;
            this.lpprDataGridView.Size = new System.Drawing.Size(444, 190);
            this.lpprDataGridView.TabIndex = 4;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refundBaseDataGridViewTextBoxColumn
            // 
            this.refundBaseDataGridViewTextBoxColumn.DataPropertyName = "RefundBase";
            this.refundBaseDataGridViewTextBoxColumn.HeaderText = "RefundBase";
            this.refundBaseDataGridViewTextBoxColumn.Name = "refundBaseDataGridViewTextBoxColumn";
            this.refundBaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coefDataGridViewTextBoxColumn
            // 
            this.coefDataGridViewTextBoxColumn.DataPropertyName = "Coef";
            this.coefDataGridViewTextBoxColumn.HeaderText = "Coef";
            this.coefDataGridViewTextBoxColumn.Name = "coefDataGridViewTextBoxColumn";
            this.coefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actCodeDataGridViewTextBoxColumn
            // 
            this.actCodeDataGridViewTextBoxColumn.DataPropertyName = "ActCode";
            this.actCodeDataGridViewTextBoxColumn.HeaderText = "ActCode";
            this.actCodeDataGridViewTextBoxColumn.Name = "actCodeDataGridViewTextBoxColumn";
            this.actCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lpprBindingSource
            // 
            this.lpprBindingSource.DataSource = typeof(AtomTester.Lppr);
            // 
            // marcketLabel
            // 
            this.marcketLabel.AutoSize = true;
            this.marcketLabel.Location = new System.Drawing.Point(724, 58);
            this.marcketLabel.Name = "marcketLabel";
            this.marcketLabel.Size = new System.Drawing.Size(35, 13);
            this.marcketLabel.TabIndex = 5;
            this.marcketLabel.Text = "label1";
            // 
            // PackDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 838);
            this.Controls.Add(this.marcketLabel);
            this.Controls.Add(this.lpprDataGridView);
            this.Controls.Add(this.saumonTreeView);
            this.Controls.Add(this.monographWebBrowser);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.libelleTextBox);
            this.Name = "PackDetail";
            this.Text = "PackDetail";
            ((System.ComponentModel.ISupportInitialize)(this.lpprDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpprBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox libelleTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.WebBrowser monographWebBrowser;
        private System.Windows.Forms.TreeView saumonTreeView;
        private System.Windows.Forms.DataGridView lpprDataGridView;
        private System.Windows.Forms.BindingSource lpprBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label marcketLabel;
    }
}