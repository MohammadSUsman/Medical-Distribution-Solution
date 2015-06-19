using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medcine_ManagmentSystem
{
    public partial class frmCompanyPayment : Form
    {
        public frmCompanyPayment()
        {
            InitializeComponent();
        }

        private void frmCompanyPayment_Load(object sender, EventArgs e)
        {
            getTableCompanyPaymentData();
            cmbCompanyId.DataSource = Company.getTable();
            cmbCompanyId.DisplayMember = "CompanyName";
            cmbCompanyId.ValueMember = "CompanyID";
        }
        private void getTableCompanyPaymentData()
        {
            dgvCompanyPayment.DataSource = CompanyPayment.getTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CompanyPayment.Insert(Convert.ToInt32(txtVoucherID.Text), (Convert.ToInt32(cmbCompanyId.SelectedValue.ToString())), (Convert.ToInt32(txtAmount.Text)), txtDateAndTime.Text))
            {
                MessageBox.Show("data has been inserted");
                getTableCompanyPaymentData();
            }
            else
            {
                MessageBox.Show("data hasnot been inserted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CompanyPayment.Update(Convert.ToInt32(txtVoucherID.Text), txtDateAndTime.Text, (Convert.ToInt32(txtAmount.Text)), (Convert.ToInt32(cmbCompanyId.SelectedValue.ToString()))))
            {
                MessageBox.Show("data has been update");
                getTableCompanyPaymentData();
            }
            else
            {
                MessageBox.Show("data hasnot been inserted");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CompanyPayment.Delete(Convert.ToInt32(txtVoucherID.Text)))
            {
                MessageBox.Show("data has been update");
                getTableCompanyPaymentData();
            }
            else
            {
                MessageBox.Show("data hasnot been inserted");
            }

        }
        public  void ClearData()
        {
            txtVoucherID.Clear();
            txtAmount.Clear();
            txtDateAndTime.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }



    }
}
