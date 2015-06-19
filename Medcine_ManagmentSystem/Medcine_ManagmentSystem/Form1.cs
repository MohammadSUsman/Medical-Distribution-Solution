using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Medcine_ManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel2.Height = this.Height;
          //  llableProfile.Links link = new lin
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }

            frmSales Sales = new frmSales();
            Sales.MdiParent = this;
            Sales.Location = new Point(220, 157);
            Sales.Show();
            
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }
            
            //for the Compnay
            
            frmCompany company = new frmCompany();
            company.MdiParent = this;
            company.Location = new Point(220,157);
            company.Show();
            
            //company.Width = this.Width-250;
            //company.Height = this.Height-220;
            

            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmCompany")
                {
                    frm.Focus();
                    FormFound = true;
                }
                else
                {
                    FormFound = false;
                }
            }
                //if (FormFound == false)
                //{
                //    Form2 f = new form2();
                //    f.Show();
                //}
            
 
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }

            frmCustomer Customer = new frmCustomer();
            Customer.MdiParent = this;
            Customer.Location = new Point(220, 157);
            Customer.Show();
            
            
            
            //frmCustomer customer = new frmCustomer();
            //customer.MdiParent = this;
            //customer.Show();

        }

        private void btnCustomerPayment_Click(object sender, EventArgs e)
        {

            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }

            frmCompanyPayment CompanyPayment = new frmCompanyPayment();
            CompanyPayment.MdiParent = this;
            CompanyPayment.Location =new Point (220, 157);
            CompanyPayment.Show();

        }

        private void btnCustomerRecipit_Click(object sender, EventArgs e)
        {
            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }

            //for the CustomerRecipt
            frmCustomerRecipit customerRecipt = new frmCustomerRecipit();
            customerRecipt.MdiParent = this;
            customerRecipt.Location = new Point(220, 157);
            customerRecipt.Show();
            
            
            
          
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }

            frmMedicine Medicine = new frmMedicine();
            Medicine.MdiParent = this;
            Medicine.Location = new Point (220, 157);
            Medicine.Show();
        }

        private void btnPurches_Click(object sender, EventArgs e)
        {

            FormCollection openForm = Application.OpenForms;
            Form[] list = new Form[openForm.Count];

            for (int i = 0; i < openForm.Count; i++)
            {
                list[i] = openForm[i];
            }
            openForm = null;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name != this.Name)
                {
                    list[i].Close();
                }

            }
            
            
            frmPurchase purchase = new frmPurchase();
            purchase.MdiParent = this;
            purchase.Location = new Point(220, 157);
            purchase.Show();
        }
        private void companyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsCompany1.Clear();
            DACompany.Fill(dsCompany1);
            RptCompany company = new RptCompany();
            company.SetDataSource(dsCompany1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = company;
            rv.Location = new Point(220, 160);
            rv.MdiParent = this;
            rv.Show();
        }

        private void compToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DACompanyPayment.Fill(dsCompanyPayment1);
            rptCompanyPayment CompanyPayment = new rptCompanyPayment();
            CompanyPayment.SetDataSource(dsCompanyPayment1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = CompanyPayment;
            rv.Location = new Point(220, 160);
            rv.MdiParent = this;
            rv.Show();
        }

        private void customerRecipitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DACustomerRecipit.Fill(dsCustomerRecipit1);
            rptCustomerRecipit CustomerRecipit = new rptCustomerRecipit();
            CustomerRecipit.SetDataSource(dsCustomerRecipit1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = CustomerRecipit;
            rv.Location = new Point(220, 160);
            rv.MdiParent = this;
            rv.Show();

        }

        private void medicineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAMedicine.Fill(dsMedicine1);
            rptMedicine Medicine = new rptMedicine();
            Medicine.SetDataSource(dsMedicine1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = Medicine;
            rv.Location = new Point(220, 160);
            rv.MdiParent = this;
            rv.Show();

            

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DASales.Fill(dsSales1);
            rptSales Sales = new rptSales();
            Sales.SetDataSource(dsSales1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = Sales;
            rv.Location = new Point(220,160);
            rv.MdiParent = this;
            rv.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DACustomer.Fill(dsCustomer1);
            rptCusotmer customer = new rptCusotmer();
            customer.SetDataSource(dsCustomer1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = customer;
            rv.Location = new Point(220, 160);
            rv.MdiParent = this;
            rv.Show();

        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAPurchase.Fill(dsMedicine1);
            rptPurchase pur = new rptPurchase();
            pur.SetDataSource(dsPurchase1);
            ReportViewr rv = new ReportViewr();
            rv.CRV.ReportSource = pur;
            rv.Location = new Point(220, 160);
            rv.MdiParent = this;
            rv.Show();
        }
    }
}
