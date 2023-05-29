namespace BANKING_FINAL
{
    partial class SQL
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bANKINGDataSet = new BANKING_FINAL.BANKINGDataSet();
            this.tAKEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAKETableAdapter = new BANKING_FINAL.BANKINGDataSetTableAdapters.TAKETableAdapter();
            this.bANKINGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAKEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aDDINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDDINGTableAdapter = new BANKING_FINAL.BANKINGDataSetTableAdapters.ADDINGTableAdapter();
            this.bANKINGDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tAKEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tAKEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.aDDINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aDDINGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new BANKING_FINAL.BANKINGDataSetTableAdapters.TableAdapterManager();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new BANKING_FINAL.BANKINGDataSetTableAdapters.EMPLOYEETableAdapter();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANTableAdapter = new BANKING_FINAL.BANKINGDataSetTableAdapters.LOANTableAdapter();
            this.bRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANCHTableAdapter = new BANKING_FINAL.BANKINGDataSetTableAdapters.BRANCHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINGBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(376, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "BRANCH THAT HAS NO CUSTOMERS ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(376, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "RETRIEVE INFORMATIOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(376, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(392, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "BRANCH THAT HAS NO EMPLOYEES ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(376, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(392, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "EMPLOYEE WITH MAX NUMBER OF LOANS ADDED";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(376, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "CUSTOMER WITH MAX NUMBER OF LOANS TAKEN";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(376, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(392, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "CUSTOMERS WITH NO LOANS TAKEN";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(337, 427);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bANKINGDataSet
            // 
            this.bANKINGDataSet.DataSetName = "BANKINGDataSet";
            this.bANKINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAKEBindingSource
            // 
            this.tAKEBindingSource.DataMember = "TAKE";
            this.tAKEBindingSource.DataSource = this.bANKINGDataSet;
            // 
            // tAKETableAdapter
            // 
            this.tAKETableAdapter.ClearBeforeFill = true;
            // 
            // bANKINGDataSetBindingSource
            // 
            this.bANKINGDataSetBindingSource.DataSource = this.bANKINGDataSet;
            this.bANKINGDataSetBindingSource.Position = 0;
            // 
            // tAKEBindingSource1
            // 
            this.tAKEBindingSource1.DataMember = "TAKE";
            this.tAKEBindingSource1.DataSource = this.bANKINGDataSetBindingSource;
            // 
            // aDDINGBindingSource
            // 
            this.aDDINGBindingSource.DataMember = "ADDING";
            this.aDDINGBindingSource.DataSource = this.bANKINGDataSetBindingSource;
            // 
            // aDDINGTableAdapter
            // 
            this.aDDINGTableAdapter.ClearBeforeFill = true;
            // 
            // bANKINGDataSetBindingSource1
            // 
            this.bANKINGDataSetBindingSource1.DataSource = this.bANKINGDataSet;
            this.bANKINGDataSetBindingSource1.Position = 0;
            // 
            // tAKEBindingSource2
            // 
            this.tAKEBindingSource2.DataMember = "TAKE";
            this.tAKEBindingSource2.DataSource = this.bANKINGDataSetBindingSource;
            // 
            // tAKEBindingSource3
            // 
            this.tAKEBindingSource3.DataMember = "TAKE";
            this.tAKEBindingSource3.DataSource = this.bANKINGDataSetBindingSource1;
            // 
            // aDDINGBindingSource1
            // 
            this.aDDINGBindingSource1.DataMember = "ADDING";
            this.aDDINGBindingSource1.DataSource = this.bANKINGDataSetBindingSource1;
            // 
            // aDDINGBindingSource2
            // 
            this.aDDINGBindingSource2.DataMember = "ADDING";
            this.aDDINGBindingSource2.DataSource = this.bANKINGDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = null;
            this.tableAdapterManager.ADDINGTableAdapter = this.aDDINGTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANKTableAdapter = null;
            this.tableAdapterManager.BRANCHTableAdapter = this.bRANCHTableAdapter;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.haveTableAdapter = null;
            this.tableAdapterManager.LOANTableAdapter = this.lOANTableAdapter;
            this.tableAdapterManager.TAKETableAdapter = this.tAKETableAdapter;
            this.tableAdapterManager.UpdateOrder = BANKING_FINAL.BANKINGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.bANKINGDataSet;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // lOANBindingSource
            // 
            this.lOANBindingSource.DataMember = "LOAN";
            this.lOANBindingSource.DataSource = this.bANKINGDataSet;
            // 
            // lOANTableAdapter
            // 
            this.lOANTableAdapter.ClearBeforeFill = true;
            // 
            // bRANCHBindingSource
            // 
            this.bRANCHBindingSource.DataMember = "BRANCH";
            this.bRANCHBindingSource.DataSource = this.bANKINGDataSetBindingSource;
            // 
            // bRANCHTableAdapter
            // 
            this.bRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANKING_FINAL.Properties.Resources.bank_employee_reinstatement_2;
            this.ClientSize = new System.Drawing.Size(836, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SQL";
            this.Text = "SQL";
            this.Load += new System.EventHandler(this.SQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKINGDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINGBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BANKINGDataSet bANKINGDataSet;
        private System.Windows.Forms.BindingSource tAKEBindingSource;
        private BANKINGDataSetTableAdapters.TAKETableAdapter tAKETableAdapter;
        private System.Windows.Forms.BindingSource tAKEBindingSource1;
        private System.Windows.Forms.BindingSource bANKINGDataSetBindingSource;
        private System.Windows.Forms.BindingSource aDDINGBindingSource;
        private BANKINGDataSetTableAdapters.ADDINGTableAdapter aDDINGTableAdapter;
        private System.Windows.Forms.BindingSource tAKEBindingSource3;
        private System.Windows.Forms.BindingSource bANKINGDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tAKEBindingSource2;
        private System.Windows.Forms.BindingSource aDDINGBindingSource1;
        private System.Windows.Forms.BindingSource aDDINGBindingSource2;
        private BANKINGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BANKINGDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private BANKINGDataSetTableAdapters.LOANTableAdapter lOANTableAdapter;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private BANKINGDataSetTableAdapters.BRANCHTableAdapter bRANCHTableAdapter;
        private System.Windows.Forms.BindingSource bRANCHBindingSource;
    }
}