namespace Medcine_ManagmentSystem
{
    partial class frmCustomerRecipit
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
            this.dgvCustomerRecipit = new System.Windows.Forms.DataGridView();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.txtDateAndTime = new System.Windows.Forms.TextBox();
            this.lblVoucherID = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbCompanyId = new System.Windows.Forms.ComboBox();
            this.cmbCustomerRecipit = new System.Windows.Forms.ComboBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACustomerRecipit = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecipit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerRecipit
            // 
            this.dgvCustomerRecipit.AllowUserToAddRows = false;
            this.dgvCustomerRecipit.AllowUserToDeleteRows = false;
            this.dgvCustomerRecipit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomerRecipit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRecipit.Location = new System.Drawing.Point(243, 313);
            this.dgvCustomerRecipit.Name = "dgvCustomerRecipit";
            this.dgvCustomerRecipit.ReadOnly = true;
            this.dgvCustomerRecipit.Size = new System.Drawing.Size(582, 250);
            this.dgvCustomerRecipit.TabIndex = 33;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(609, 245);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(96, 39);
            this.btnRight.TabIndex = 32;
            this.btnRight.Text = "Right ->";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(487, 245);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(96, 39);
            this.btnForward.TabIndex = 31;
            this.btnForward.Text = "Forward =>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(365, 245);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(96, 39);
            this.btnBackward.TabIndex = 30;
            this.btnBackward.Text = "Backward <=";
            this.btnBackward.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(243, 245);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(96, 39);
            this.btnLeft.TabIndex = 29;
            this.btnLeft.Text = "Left <-";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(609, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 39);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(487, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 39);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(365, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 39);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(207, 51);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(102, 20);
            this.lblCompanyID.TabIndex = 25;
            this.lblCompanyID.Text = "CompanyID";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(207, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 23;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(349, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(356, 20);
            this.txtAmount.TabIndex = 22;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(197, 99);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(118, 20);
            this.lblDateAndTime.TabIndex = 21;
            this.lblDateAndTime.Text = "DateAndTiem";
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Location = new System.Drawing.Point(349, 99);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(356, 20);
            this.txtDateAndTime.TabIndex = 20;
            // 
            // lblVoucherID
            // 
            this.lblVoucherID.AutoSize = true;
            this.lblVoucherID.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherID.Location = new System.Drawing.Point(207, 25);
            this.lblVoucherID.Name = "lblVoucherID";
            this.lblVoucherID.Size = new System.Drawing.Size(100, 20);
            this.lblVoucherID.TabIndex = 19;
            this.lblVoucherID.Text = "Voucher ID";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(243, 164);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 39);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbCompanyId
            // 
            this.cmbCompanyId.FormattingEnabled = true;
            this.cmbCompanyId.Location = new System.Drawing.Point(349, 46);
            this.cmbCompanyId.Name = "cmbCompanyId";
            this.cmbCompanyId.Size = new System.Drawing.Size(356, 21);
            this.cmbCompanyId.TabIndex = 34;
            // 
            // cmbCustomerRecipit
            // 
            this.cmbCustomerRecipit.FormattingEnabled = true;
            this.cmbCustomerRecipit.Location = new System.Drawing.Point(349, 12);
            this.cmbCustomerRecipit.Name = "cmbCustomerRecipit";
            this.cmbCustomerRecipit.Size = new System.Drawing.Size(356, 21);
            this.cmbCustomerRecipit.TabIndex = 35;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        VoucherID, DateAndTime, Amount, CompanyId\r\nFROM            Customer" +
                "Recipit";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Medicine;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [CustomerRecipit] ([VoucherID], [DateAndTime], [Amount], [CompanyId])" +
                " VALUES (@VoucherID, @DateAndTime, @Amount, @CompanyId)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VoucherID", System.Data.SqlDbType.VarChar, 0, "VoucherID"),
            new System.Data.SqlClient.SqlParameter("@DateAndTime", System.Data.SqlDbType.VarChar, 0, "DateAndTime"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Int, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@CompanyId", System.Data.SqlDbType.VarChar, 0, "CompanyId")});
            // 
            // sqlDACustomerRecipit
            // 
            this.sqlDACustomerRecipit.InsertCommand = this.sqlInsertCommand1;
            this.sqlDACustomerRecipit.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACustomerRecipit.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CustomerRecipit", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VoucherID", "VoucherID"),
                        new System.Data.Common.DataColumnMapping("DateAndTime", "DateAndTime"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("CompanyId", "CompanyId")})});
            // 
            // frmCustomerRecipit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::Medcine_ManagmentSystem.Properties.Resources.customersres;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 587);
            this.Controls.Add(this.cmbCustomerRecipit);
            this.Controls.Add(this.cmbCompanyId);
            this.Controls.Add(this.dgvCustomerRecipit);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.txtDateAndTime);
            this.Controls.Add(this.lblVoucherID);
            this.Controls.Add(this.btnInsert);
            this.Location = new System.Drawing.Point(218, 185);
            this.Name = "frmCustomerRecipit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCustomerRecipit";
            this.Load += new System.EventHandler(this.CustomerRecipit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecipit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerRecipit;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.TextBox txtDateAndTime;
        private System.Windows.Forms.Label lblVoucherID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmbCompanyId;
        private System.Windows.Forms.ComboBox cmbCustomerRecipit;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDACustomerRecipit;
    }
}