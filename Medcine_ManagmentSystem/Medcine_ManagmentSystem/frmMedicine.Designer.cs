namespace Medcine_ManagmentSystem
{
    partial class frmMedicine
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
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtMedicineType = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblMenufactureDate = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.dtpMenufacture = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            //this.dsCustomer1 = new Medcine_ManagmentSystem.DSCustomer();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineName.Location = new System.Drawing.Point(57, 66);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(126, 20);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "MedicineName";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(219, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 50);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Location = new System.Drawing.Point(219, 293);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.Size = new System.Drawing.Size(582, 250);
            this.dgvMedicine.TabIndex = 17;
            this.dgvMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellClick);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.BackColor = System.Drawing.Color.Transparent;
            this.lblSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalt.Location = new System.Drawing.Point(57, 92);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(41, 20);
            this.lblSalt.TabIndex = 4;
            this.lblSalt.Text = "Salt";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.BackColor = System.Drawing.Color.Transparent;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(57, 118);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(79, 20);
            this.lblStrength.TabIndex = 5;
            this.lblStrength.Text = "Strength";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(57, 144);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(129, 20);
            this.lblCompanyName.TabIndex = 6;
            this.lblCompanyName.Text = "CompanyName";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(57, 173);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(118, 20);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "MedicineType";
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(222, 95);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(260, 20);
            this.txtSalt.TabIndex = 2;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(222, 118);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(260, 20);
            this.txtStrength.TabIndex = 4;
            // 
            // txtMedicineType
            // 
            this.txtMedicineType.Location = new System.Drawing.Point(222, 173);
            this.txtMedicineType.Name = "txtMedicineType";
            this.txtMedicineType.Size = new System.Drawing.Size(260, 20);
            this.txtMedicineType.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(518, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(518, 114);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(96, 20);
            this.lblExpiryDate.TabIndex = 20;
            this.lblExpiryDate.Text = "ExpiryDate";
            // 
            // lblMenufactureDate
            // 
            this.lblMenufactureDate.AutoSize = true;
            this.lblMenufactureDate.BackColor = System.Drawing.Color.Transparent;
            this.lblMenufactureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenufactureDate.Location = new System.Drawing.Point(518, 91);
            this.lblMenufactureDate.Name = "lblMenufactureDate";
            this.lblMenufactureDate.Size = new System.Drawing.Size(149, 20);
            this.lblMenufactureDate.TabIndex = 19;
            this.lblMenufactureDate.Text = "MenufactureDate";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.Location = new System.Drawing.Point(518, 62);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(78, 20);
            this.lblBatchNo.TabIndex = 17;
            this.lblBatchNo.Text = "BatchNo";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(680, 144);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(680, 62);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(260, 20);
            this.txtBatchNo.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(380, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 50);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(543, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 50);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(709, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 50);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(222, 144);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(260, 21);
            this.cmbMedicine.TabIndex = 6;
            // 
            // dtpMenufacture
            // 
            this.dtpMenufacture.Location = new System.Drawing.Point(680, 89);
            this.dtpMenufacture.Name = "dtpMenufacture";
            this.dtpMenufacture.Size = new System.Drawing.Size(260, 20);
            this.dtpMenufacture.TabIndex = 3;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(680, 115);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(260, 20);
            this.dtpExpiry.TabIndex = 5;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(680, 173);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(260, 20);
            this.txtCompanyID.TabIndex = 9;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(518, 172);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(102, 20);
            this.lblCompanyID.TabIndex = 37;
            this.lblCompanyID.Text = "CompanyID";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Medicine.*\r\nFROM            Medicine";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Medicine;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Medicine] ([MedicineName], [Salt], [Strength], [CompanyID], [Type]) " +
                "VALUES (@MedicineName, @Salt, @Strength, @CompanyID, @Type)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@MedicineName", System.Data.SqlDbType.VarChar, 0, "MedicineName"),
            new System.Data.SqlClient.SqlParameter("@Salt", System.Data.SqlDbType.VarChar, 0, "Salt"),
            new System.Data.SqlClient.SqlParameter("@Strength", System.Data.SqlDbType.Int, 0, "Strength"),
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.VarChar, 0, "CompanyID"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Char, 0, "Type")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Medicine", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MedicineName", "MedicineName"),
                        new System.Data.Common.DataColumnMapping("Salt", "Salt"),
                        new System.Data.Common.DataColumnMapping("Strength", "Strength"),
                        new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID"),
                        new System.Data.Common.DataColumnMapping("Type", "Type")})});
            // 
            // dsCustomer1
            // 
            //this.dsCustomer1.DataSetName = "DSCustomer";
           // this.dsCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(222, 66);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(260, 20);
            this.txtMedicineName.TabIndex = 39;
            // 
            // frmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = global::Medcine_ManagmentSystem.Properties.Resources.minimalistic_medicine_00337517;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 587);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.dtpMenufacture);
            this.Controls.Add(this.cmbMedicine);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblMenufactureDate);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.txtMedicineType);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblMedicineName);
            this.Location = new System.Drawing.Point(218, 185);
            this.Name = "frmMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmMedicine";
            this.Load += new System.EventHandler(this.frmMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtMedicineType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblMenufactureDate;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.DateTimePicker dtpMenufacture;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        
        private System.Windows.Forms.TextBox txtMedicineName;
    }
}