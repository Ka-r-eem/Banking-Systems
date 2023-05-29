namespace BANKING_FINAL
{
    partial class CUS_LIST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTOMERSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSUSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSPASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOOFLOANSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANKINGDataSet = new BANKING_FINAL.BANKINGDataSet();
            this.cUSTOMERTableAdapter = new BANKING_FINAL.BANKINGDataSetTableAdapters.CUSTOMERTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTOMERSSNDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.cUSTOMERPHONEDataGridViewTextBoxColumn,
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn,
            this.cUSUSERNAMEDataGridViewTextBoxColumn,
            this.cUSPASSDataGridViewTextBoxColumn,
            this.nOOFLOANSDataGridViewTextBoxColumn,
            this.bRANCHNUMBERDataGridViewTextBoxColumn,
            this.bANKCODEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // cUSTOMERSSNDataGridViewTextBoxColumn
            // 
            this.cUSTOMERSSNDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_SSN";
            this.cUSTOMERSSNDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_SSN";
            this.cUSTOMERSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERSSNDataGridViewTextBoxColumn.Name = "cUSTOMERSSNDataGridViewTextBoxColumn";
            this.cUSTOMERSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTOMERPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_PHONE";
            this.cUSTOMERPHONEDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_PHONE";
            this.cUSTOMERPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERPHONEDataGridViewTextBoxColumn.Name = "cUSTOMERPHONEDataGridViewTextBoxColumn";
            this.cUSTOMERPHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ADDRESS";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ADDRESS";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Name = "cUSTOMERADDRESSDataGridViewTextBoxColumn";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSUSERNAMEDataGridViewTextBoxColumn
            // 
            this.cUSUSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUS_USERNAME";
            this.cUSUSERNAMEDataGridViewTextBoxColumn.HeaderText = "CUS_USERNAME";
            this.cUSUSERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSUSERNAMEDataGridViewTextBoxColumn.Name = "cUSUSERNAMEDataGridViewTextBoxColumn";
            this.cUSUSERNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSPASSDataGridViewTextBoxColumn
            // 
            this.cUSPASSDataGridViewTextBoxColumn.DataPropertyName = "CUS_PASS";
            this.cUSPASSDataGridViewTextBoxColumn.HeaderText = "CUS_PASS";
            this.cUSPASSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSPASSDataGridViewTextBoxColumn.Name = "cUSPASSDataGridViewTextBoxColumn";
            this.cUSPASSDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOOFLOANSDataGridViewTextBoxColumn
            // 
            this.nOOFLOANSDataGridViewTextBoxColumn.DataPropertyName = "NO_OF_LOANS";
            this.nOOFLOANSDataGridViewTextBoxColumn.HeaderText = "NO_OF_LOANS";
            this.nOOFLOANSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOOFLOANSDataGridViewTextBoxColumn.Name = "nOOFLOANSDataGridViewTextBoxColumn";
            this.nOOFLOANSDataGridViewTextBoxColumn.Width = 125;
            // 
            // bRANCHNUMBERDataGridViewTextBoxColumn
            // 
            this.bRANCHNUMBERDataGridViewTextBoxColumn.DataPropertyName = "BRANCH_NUMBER";
            this.bRANCHNUMBERDataGridViewTextBoxColumn.HeaderText = "BRANCH_NUMBER";
            this.bRANCHNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bRANCHNUMBERDataGridViewTextBoxColumn.Name = "bRANCHNUMBERDataGridViewTextBoxColumn";
            this.bRANCHNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // bANKCODEDataGridViewTextBoxColumn
            // 
            this.bANKCODEDataGridViewTextBoxColumn.DataPropertyName = "BANK_CODE";
            this.bANKCODEDataGridViewTextBoxColumn.HeaderText = "BANK_CODE";
            this.bANKCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bANKCODEDataGridViewTextBoxColumn.Name = "bANKCODEDataGridViewTextBoxColumn";
            this.bANKCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.bANKINGDataSet;
            // 
            // bANKINGDataSet
            // 
            this.bANKINGDataSet.DataSetName = "BANKINGDataSet";
            this.bANKINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMERS DATA :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(809, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "RETURN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CUS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANKING_FINAL.Properties.Resources.bank_employee_reinstatement_2;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CUS_LIST";
            this.Text = "CUS_LIST";
            this.Load += new System.EventHandler(this.CUS_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BANKINGDataSet bANKINGDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private BANKINGDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSUSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSPASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOOFLOANSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}