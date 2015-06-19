namespace Medcine_ManagmentSystem
{
    partial class frmCompanyPayment
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtVoucherID = new System.Windows.Forms.TextBox();
            this.lblVoucherID = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.dgvCompanyPayment = new System.Windows.Forms.DataGridView();
            this.txtDateAndTime = new System.Windows.Forms.TextBox();
            this.cmbCompanyId = new System.Windows.Forms.ComboBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
          
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyPayment)).BeginInit();
         
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(215, 172);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 39);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtVoucherID
            // 
            this.txtVoucherID.Location = new System.Drawing.Point(321, 29);
            this.txtVoucherID.Name = "txtVoucherID";
            this.txtVoucherID.Size = new System.Drawing.Size(356, 20);
            this.txtVoucherID.TabIndex = 1;
            // 
            // lblVoucherID
            // 
            this.lblVoucherID.AutoSize = true;
            this.lblVoucherID.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherID.Location = new System.Drawing.Point(200, 29);
            this.lblVoucherID.Name = "lblVoucherID";
            this.lblVoucherID.Size = new System.Drawing.Size(100, 20);
            this.lblVoucherID.TabIndex = 0;
            this.lblVoucherID.Text = "Voucher ID";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(190, 103);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(118, 20);
            this.lblDateAndTime.TabIndex = 6;
            this.lblDateAndTime.Text = "DateAndTime";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(200, 77);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(321, 81);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(356, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(200, 55);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(102, 20);
            this.lblCompanyID.TabIndex = 2;
            this.lblCompanyID.Text = "CompanyID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(337, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(581, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(581, 217);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(116, 39);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "Right ->";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(459, 217);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 39);
            this.btnForward.TabIndex = 14;
            this.btnForward.Text = "Forward =>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(337, 217);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(116, 39);
            this.btnBackward.TabIndex = 13;
            this.btnBackward.Text = "Backward <=";
            this.btnBackward.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(215, 217);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(116, 39);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "Left <-";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // dgvCompanyPayment
            // 
            this.dgvCompanyPayment.AllowUserToAddRows = false;
            this.dgvCompanyPayment.AllowUserToDeleteRows = false;
            this.dgvCompanyPayment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCompanyPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyPayment.Location = new System.Drawing.Point(215, 281);
            this.dgvCompanyPayment.Name = "dgvCompanyPayment";
            this.dgvCompanyPayment.ReadOnly = true;
            this.dgvCompanyPayment.Size = new System.Drawing.Size(582, 250);
            this.dgvCompanyPayment.TabIndex = 16;
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Location = new System.Drawing.Point(321, 107);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(356, 20);
            this.txtDateAndTime.TabIndex = 7;
            // 
            // cmbCompanyId
            // 
            this.cmbCompanyId.FormattingEnabled = true;
            this.cmbCompanyId.Location = new System.Drawing.Point(321, 54);
            this.cmbCompanyId.Name = "cmbCompanyId";
            this.cmbCompanyId.Size = new System.Drawing.Size(356, 21);
            this.cmbCompanyId.TabIndex = 17;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        CompanyPayment.*\r\nFROM            CompanyPayment";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [CompanyPayment] ([VoucherID], [DateAndTime], [Amount], [CompanyID]) " +
                "VALUES (@VoucherID, @DateAndTime, @Amount, @CompanyID)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VoucherID", System.Data.SqlDbType.Int, 0, "VoucherID"),
            new System.Data.SqlClient.SqlParameter("@DateAndTime", System.Data.SqlDbType.Char, 0, "DateAndTime"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.Int, 0, "CompanyID")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompanyPayment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VoucherID", "VoucherID"),
                        new System.Data.Common.DataColumnMapping("DateAndTime", "DateAndTime"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Medicine;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsCompanyPayment1
            // 
           
            // frmCompanyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::Medcine_ManagmentSystem.Properties.Resources.online_payment_processing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 587);
            this.Controls.Add(this.cmbCompanyId);
            this.Controls.Add(this.txtDateAndTime);
            this.Controls.Add(this.dgvCompanyPayment);
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
            this.Controls.Add(this.lblVoucherID);
            this.Controls.Add(this.txtVoucherID);
            this.Controls.Add(this.btnInsert);
            this.Location = new System.Drawing.Point(218, 185);
            this.Name = "frmCompanyPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCompanyPayment";
            this.Load += new System.EventHandler(this.frmCompanyPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyPayment)).EndInit();
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtVoucherID;
        private System.Windows.Forms.Label lblVoucherID;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.DataGridView dgvCompanyPayment;
        private System.Windows.Forms.TextBox txtDateAndTime;
        private System.Windows.Forms.ComboBox cmbCompanyId;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        
    }
}