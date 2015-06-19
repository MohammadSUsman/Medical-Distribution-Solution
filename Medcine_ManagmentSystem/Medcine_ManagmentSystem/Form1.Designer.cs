namespace Medcine_ManagmentSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRecipitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomerRecipit = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPurches = new System.Windows.Forms.Button();
            this.btnCustomerPayment = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.DACompany = new System.Data.SqlClient.SqlDataAdapter();
            this.dsCompany1 = new Medcine_ManagmentSystem.dsCompany();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.DACompanyPayment = new System.Data.SqlClient.SqlDataAdapter();
            this.dsCompanyPayment1 = new Medcine_ManagmentSystem.DSCompanyPayment();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.DACustomerRecipit = new System.Data.SqlClient.SqlDataAdapter();
            this.dsCustomerRecipit1 = new Medcine_ManagmentSystem.DSCustomerRecipit();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.DACustomer = new System.Data.SqlClient.SqlDataAdapter();
            this.dsCustomer1 = new Medcine_ManagmentSystem.DSCustomer();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
            this.DAMedicine = new System.Data.SqlClient.SqlDataAdapter();
            this.dsMedicine1 = new Medcine_ManagmentSystem.DSMedicine();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.DASales = new System.Data.SqlClient.SqlDataAdapter();
            this.dsSales1 = new Medcine_ManagmentSystem.DSSales();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.DAPurchase = new System.Data.SqlClient.SqlDataAdapter();
            this.dsPurchase1 = new Medcine_ManagmentSystem.DSPurchase();
            this.menuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompany1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompanyPayment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerRecipit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(271, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyReportToolStripMenuItem,
            this.customerReportToolStripMenuItem,
            this.compToolStripMenuItem,
            this.medicineReportToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.purchaseReportToolStripMenuItem,
            this.customerRecipitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fileToolStripMenuItem.Text = "Reports";
            // 
            // companyReportToolStripMenuItem
            // 
            this.companyReportToolStripMenuItem.Name = "companyReportToolStripMenuItem";
            this.companyReportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.companyReportToolStripMenuItem.Text = "CompanyReport";
            this.companyReportToolStripMenuItem.Click += new System.EventHandler(this.companyReportToolStripMenuItem_Click);
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.customerReportToolStripMenuItem.Text = "CustomerReport";
            this.customerReportToolStripMenuItem.Click += new System.EventHandler(this.customerReportToolStripMenuItem_Click);
            // 
            // compToolStripMenuItem
            // 
            this.compToolStripMenuItem.Name = "compToolStripMenuItem";
            this.compToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.compToolStripMenuItem.Text = "CompanyPaymentReport";
            this.compToolStripMenuItem.Click += new System.EventHandler(this.compToolStripMenuItem_Click);
            // 
            // medicineReportToolStripMenuItem
            // 
            this.medicineReportToolStripMenuItem.Name = "medicineReportToolStripMenuItem";
            this.medicineReportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.medicineReportToolStripMenuItem.Text = "MedicineReport";
            this.medicineReportToolStripMenuItem.Click += new System.EventHandler(this.medicineReportToolStripMenuItem_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.salesReportToolStripMenuItem.Text = "SalesReport";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // purchaseReportToolStripMenuItem
            // 
            this.purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            this.purchaseReportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.purchaseReportToolStripMenuItem.Text = "PurchaseReport";
            this.purchaseReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportToolStripMenuItem_Click);
            // 
            // customerRecipitToolStripMenuItem
            // 
            this.customerRecipitToolStripMenuItem.Name = "customerRecipitToolStripMenuItem";
            this.customerRecipitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.customerRecipitToolStripMenuItem.Text = "CustomerRecipit";
            this.customerRecipitToolStripMenuItem.Click += new System.EventHandler(this.customerRecipitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1424, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedicine.Location = new System.Drawing.Point(11, 365);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(191, 53);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.Location = new System.Drawing.Point(11, 453);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(191, 53);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustomerRecipit
            // 
            this.btnCustomerRecipit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerRecipit.Location = new System.Drawing.Point(11, 280);
            this.btnCustomerRecipit.Name = "btnCustomerRecipit";
            this.btnCustomerRecipit.Size = new System.Drawing.Size(191, 53);
            this.btnCustomerRecipit.TabIndex = 3;
            this.btnCustomerRecipit.Text = "Customer Recipit";
            this.btnCustomerRecipit.UseVisualStyleBackColor = true;
            this.btnCustomerRecipit.Click += new System.EventHandler(this.btnCustomerRecipit_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Location = new System.Drawing.Point(11, 119);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(191, 53);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPurches
            // 
            this.btnPurches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurches.Location = new System.Drawing.Point(11, 532);
            this.btnPurches.Name = "btnPurches";
            this.btnPurches.Size = new System.Drawing.Size(191, 53);
            this.btnPurches.TabIndex = 6;
            this.btnPurches.Text = "Purchase";
            this.btnPurches.UseVisualStyleBackColor = true;
            this.btnPurches.Click += new System.EventHandler(this.btnPurches_Click);
            // 
            // btnCustomerPayment
            // 
            this.btnCustomerPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerPayment.Location = new System.Drawing.Point(11, 199);
            this.btnCustomerPayment.Name = "btnCustomerPayment";
            this.btnCustomerPayment.Size = new System.Drawing.Size(191, 53);
            this.btnCustomerPayment.TabIndex = 2;
            this.btnCustomerPayment.Text = "Company payment";
            this.btnCustomerPayment.UseVisualStyleBackColor = true;
            this.btnCustomerPayment.Click += new System.EventHandler(this.btnCustomerPayment_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompany.Location = new System.Drawing.Point(11, 40);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(191, 53);
            this.btnCompany.TabIndex = 5;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Medcine_ManagmentSystem.Properties.Resources.dark_minimalist_black_grill_textures_424723;
            this.panel3.Controls.Add(this.btnCompany);
            this.panel3.Controls.Add(this.btnCustomerPayment);
            this.panel3.Controls.Add(this.btnPurches);
            this.panel3.Controls.Add(this.btnCustomer);
            this.panel3.Controls.Add(this.btnCustomerRecipit);
            this.panel3.Controls.Add(this.btnSales);
            this.panel3.Controls.Add(this.btnMedicine);
            this.panel3.Location = new System.Drawing.Point(0, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 629);
            this.panel3.TabIndex = 10;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Company.*\r\nFROM            Company";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Medicine;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.Int, 0, "CompanyID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.Char, 0, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@CompanyAddress", System.Data.SqlDbType.VarChar, 0, "CompanyAddress"),
            new System.Data.SqlClient.SqlParameter("@CompanyPhone", System.Data.SqlDbType.VarChar, 0, "CompanyPhone")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.Int, 0, "CompanyID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.Char, 0, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@CompanyAddress", System.Data.SqlDbType.VarChar, 0, "CompanyAddress"),
            new System.Data.SqlClient.SqlParameter("@CompanyPhone", System.Data.SqlDbType.VarChar, 0, "CompanyPhone"),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyAddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CompanyPhone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CompanyPhone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyPhone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyPhone", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CompanyID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyAddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CompanyPhone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CompanyPhone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CompanyPhone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompanyPhone", System.Data.DataRowVersion.Original, null)});
            // 
            // DACompany
            // 
            this.DACompany.DeleteCommand = this.sqlDeleteCommand1;
            this.DACompany.InsertCommand = this.sqlInsertCommand1;
            this.DACompany.SelectCommand = this.sqlSelectCommand1;
            this.DACompany.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Company", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("CompanyAddress", "CompanyAddress"),
                        new System.Data.Common.DataColumnMapping("CompanyPhone", "CompanyPhone")})});
            this.DACompany.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dsCompany1
            // 
            this.dsCompany1.DataSetName = "dsCompany";
            this.dsCompany1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImage = global::Medcine_ManagmentSystem.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 162);
            this.panel1.TabIndex = 2;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        CompanyPayment.*\r\nFROM            CompanyPayment";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [CompanyPayment] ([VoucherID], [DateAndTime], [Amount], [CompanyID]) " +
                "VALUES (@VoucherID, @DateAndTime, @Amount, @CompanyID)";
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VoucherID", System.Data.SqlDbType.Int, 0, "VoucherID"),
            new System.Data.SqlClient.SqlParameter("@DateAndTime", System.Data.SqlDbType.Char, 0, "DateAndTime"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.Int, 0, "CompanyID")});
            // 
            // DACompanyPayment
            // 
            this.DACompanyPayment.InsertCommand = this.sqlInsertCommand2;
            this.DACompanyPayment.SelectCommand = this.sqlSelectCommand2;
            this.DACompanyPayment.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CompanyPayment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VoucherID", "VoucherID"),
                        new System.Data.Common.DataColumnMapping("DateAndTime", "DateAndTime"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID")})});
            // 
            // dsCompanyPayment1
            // 
            this.dsCompanyPayment1.DataSetName = "DSCompanyPayment";
            this.dsCompanyPayment1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        CustomerRecipit.*\r\nFROM            CustomerRecipit";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = "INSERT INTO [CustomerRecipit] ([VoucherID], [DateAndTime], [Amount], [CompanyId])" +
                " VALUES (@VoucherID, @DateAndTime, @Amount, @CompanyId)";
            this.sqlInsertCommand3.Connection = this.sqlConnection1;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VoucherID", System.Data.SqlDbType.VarChar, 0, "VoucherID"),
            new System.Data.SqlClient.SqlParameter("@DateAndTime", System.Data.SqlDbType.VarChar, 0, "DateAndTime"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Int, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@CompanyId", System.Data.SqlDbType.VarChar, 0, "CompanyId")});
            // 
            // DACustomerRecipit
            // 
            this.DACustomerRecipit.InsertCommand = this.sqlInsertCommand3;
            this.DACustomerRecipit.SelectCommand = this.sqlSelectCommand3;
            this.DACustomerRecipit.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CustomerRecipit", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VoucherID", "VoucherID"),
                        new System.Data.Common.DataColumnMapping("DateAndTime", "DateAndTime"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("CompanyId", "CompanyId")})});
            // 
            // dsCustomerRecipit1
            // 
            this.dsCustomerRecipit1.DataSetName = "DSCustomerRecipit";
            this.dsCustomerRecipit1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT        Customers.*\r\nFROM            Customers";
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.sqlConnection1;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CustomerName", System.Data.SqlDbType.Char, 0, "CustomerName"),
            new System.Data.SqlClient.SqlParameter("@CustomerAddress", System.Data.SqlDbType.NVarChar, 0, "CustomerAddress"),
            new System.Data.SqlClient.SqlParameter("@CustomerPhoneNo", System.Data.SqlDbType.Int, 0, "CustomerPhoneNo"),
            new System.Data.SqlClient.SqlParameter("@CustomerDescription", System.Data.SqlDbType.Char, 0, "CustomerDescription")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CustomerName", System.Data.SqlDbType.Char, 0, "CustomerName"),
            new System.Data.SqlClient.SqlParameter("@CustomerAddress", System.Data.SqlDbType.NVarChar, 0, "CustomerAddress"),
            new System.Data.SqlClient.SqlParameter("@CustomerPhoneNo", System.Data.SqlDbType.Int, 0, "CustomerPhoneNo"),
            new System.Data.SqlClient.SqlParameter("@CustomerDescription", System.Data.SqlDbType.Char, 0, "CustomerDescription"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerName", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerPhoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerPhoneNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerDescription", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerDescription", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerName", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerPhoneNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerPhoneNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerDescription", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerDescription", System.Data.DataRowVersion.Original, null)});
            // 
            // DACustomer
            // 
            this.DACustomer.DeleteCommand = this.sqlDeleteCommand2;
            this.DACustomer.InsertCommand = this.sqlInsertCommand4;
            this.DACustomer.SelectCommand = this.sqlSelectCommand4;
            this.DACustomer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"),
                        new System.Data.Common.DataColumnMapping("CustomerAddress", "CustomerAddress"),
                        new System.Data.Common.DataColumnMapping("CustomerPhoneNo", "CustomerPhoneNo"),
                        new System.Data.Common.DataColumnMapping("CustomerDescription", "CustomerDescription")})});
            this.DACustomer.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // dsCustomer1
            // 
            this.dsCustomer1.DataSetName = "DSCustomer";
            this.dsCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT        Medicine.*\r\nFROM            Medicine";
            this.sqlSelectCommand5.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand5
            // 
            this.sqlInsertCommand5.CommandText = "INSERT INTO [Medicine] ([MedicineName], [Salt], [Strength], [CompanyID], [Type]) " +
                "VALUES (@MedicineName, @Salt, @Strength, @CompanyID, @Type)";
            this.sqlInsertCommand5.Connection = this.sqlConnection1;
            this.sqlInsertCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@MedicineName", System.Data.SqlDbType.VarChar, 0, "MedicineName"),
            new System.Data.SqlClient.SqlParameter("@Salt", System.Data.SqlDbType.VarChar, 0, "Salt"),
            new System.Data.SqlClient.SqlParameter("@Strength", System.Data.SqlDbType.Int, 0, "Strength"),
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.VarChar, 0, "CompanyID"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Char, 0, "Type")});
            // 
            // DAMedicine
            // 
            this.DAMedicine.InsertCommand = this.sqlInsertCommand5;
            this.DAMedicine.SelectCommand = this.sqlSelectCommand5;
            this.DAMedicine.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Medicine", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MedicineName", "MedicineName"),
                        new System.Data.Common.DataColumnMapping("Salt", "Salt"),
                        new System.Data.Common.DataColumnMapping("Strength", "Strength"),
                        new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID"),
                        new System.Data.Common.DataColumnMapping("Type", "Type")})});
            // 
            // dsMedicine1
            // 
            this.dsMedicine1.DataSetName = "DSMedicine";
            this.dsMedicine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT        Sales.*\r\nFROM            Sales";
            this.sqlSelectCommand6.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand6
            // 
            this.sqlInsertCommand6.CommandText = "INSERT INTO [Sales] ([SaleID], [SaleDateAndTime], [CustomerID]) VALUES (@SaleID, " +
                "@SaleDateAndTime, @CustomerID);\r\nSELECT SaleID, SaleDateAndTime, CustomerID FROM" +
                " Sales WHERE (SaleID = @SaleID)";
            this.sqlInsertCommand6.Connection = this.sqlConnection1;
            this.sqlInsertCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SaleID", System.Data.SqlDbType.Int, 0, "SaleID"),
            new System.Data.SqlClient.SqlParameter("@SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, "SaleDateAndTime"),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlConnection1;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SaleID", System.Data.SqlDbType.Int, 0, "SaleID"),
            new System.Data.SqlClient.SqlParameter("@SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, "SaleDateAndTime"),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@Original_SaleID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleDateAndTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = "DELETE FROM [Sales] WHERE (([SaleID] = @Original_SaleID) AND ([SaleDateAndTime] =" +
                " @Original_SaleDateAndTime) AND ([CustomerID] = @Original_CustomerID))";
            this.sqlDeleteCommand3.Connection = this.sqlConnection1;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SaleID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SaleDateAndTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SaleDateAndTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null)});
            // 
            // DASales
            // 
            this.DASales.DeleteCommand = this.sqlDeleteCommand3;
            this.DASales.InsertCommand = this.sqlInsertCommand6;
            this.DASales.SelectCommand = this.sqlSelectCommand6;
            this.DASales.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SaleID", "SaleID"),
                        new System.Data.Common.DataColumnMapping("SaleDateAndTime", "SaleDateAndTime"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID")})});
            this.DASales.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // dsSales1
            // 
            this.dsSales1.DataSetName = "DSSales";
            this.dsSales1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = resources.GetString("sqlSelectCommand7.CommandText");
            this.sqlSelectCommand7.Connection = this.sqlConnection1;
            // 
            // DAPurchase
            // 
            this.DAPurchase.SelectCommand = this.sqlSelectCommand7;
            this.DAPurchase.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Purches", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PurchesID", "PurchesID"),
                        new System.Data.Common.DataColumnMapping("DateAndTime", "DateAndTime"),
                        new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID"),
                        new System.Data.Common.DataColumnMapping("MedicineName", "MedicineName"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Discount", "Discount"),
                        new System.Data.Common.DataColumnMapping("Price", "Price")})});
            // 
            // dsPurchase1
            // 
            this.dsPurchase1.DataSetName = "DSPurchase";
            this.dsPurchase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medcine_ManagmentSystem.Properties.Resources.dark_minimalist_black_grill_textures_424723;
            this.ClientSize = new System.Drawing.Size(1424, 814);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pharmacy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCompany1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompanyPayment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerRecipit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPurchase1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCustomerRecipit;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPurches;
        private System.Windows.Forms.Button btnCustomerPayment;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Panel panel3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter DACompany;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private dsCompany dsCompany1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlDataAdapter DACompanyPayment;
        private DSCompanyPayment dsCompanyPayment1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlDataAdapter DACustomerRecipit;
        private DSCustomerRecipit dsCustomerRecipit1;
        private System.Windows.Forms.ToolStripMenuItem customerRecipitToolStripMenuItem;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter DACustomer;
        private DSCustomer dsCustomer1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand5;
        private System.Data.SqlClient.SqlDataAdapter DAMedicine;
        private DSMedicine dsMedicine1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand6;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter DASales;
        private DSSales dsSales1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private System.Data.SqlClient.SqlDataAdapter DAPurchase;
        private DSPurchase dsPurchase1;
    }
}

