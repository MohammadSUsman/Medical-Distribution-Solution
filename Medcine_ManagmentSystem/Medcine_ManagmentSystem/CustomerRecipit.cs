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
    public partial class frmCustomerRecipit : Form
    {
        public frmCustomerRecipit()
        {
            InitializeComponent();
        }

        private void CustomerRecipit_Load(object sender, EventArgs e)
        {
            getCustomerRecipit();
            cmbCompanyId.DataSource = Company.getTable();
            cmbCompanyId.DisplayMember = "CompanyName";
            cmbCompanyId.ValueMember = "CompanyID";

            cmbCustomerRecipit.DataSource = CompanyPayment.getTable();
            cmbCustomerRecipit.DisplayMember = "VoucherID";
            cmbCustomerRecipit.ValueMember ="VoucherID";
        }
        public void getCustomerRecipit()
        {
            dgvCustomerRecipit.DataSource = CustomerRecpit.getTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CustomerRecpit.Insert(Convert.ToInt32(cmbCustomerRecipit.SelectedValue.ToString()), txtDateAndTime.Text, Convert.ToDouble(txtAmount.Text), (Convert.ToInt32(cmbCompanyId.SelectedValue.ToString()))))
            {
                MessageBox.Show("data has been inserted");
                getCustomerRecipit();
            }
            else
            {
                MessageBox.Show("data has not been inserted");
            }
            
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerRecpit.Update(Convert.ToInt32(cmbCustomerRecipit.SelectedValue.ToString()), txtDateAndTime.Text, Convert.ToDouble(txtAmount.Text), (Convert.ToInt32(cmbCompanyId.SelectedValue.ToString()))))
            {
                MessageBox.Show("update");
                getCustomerRecipit();
            }
            else
            {
                MessageBox.Show("data has not been updated");
                 getCustomerRecipit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CustomerRecpit.Delete(Convert.ToInt32(cmbCustomerRecipit.SelectedValue.ToString())))
            {
                MessageBox.Show("delete");
                getCustomerRecipit();
            }
            else
            {
                MessageBox.Show("not delete");
                getCustomerRecipit();
            }
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (CustomerRecpit.Insert(Convert.ToInt32(txtVocherID.Text), (Convert.ToInt32(txtCompanyID.Text)), (Convert.ToInt32(txtAmount.Text)), txtDateAndTime.Text))
        //    {
        //        MessageBox.Show("data has been Update");
        //        getCustomerRecipit();
        //    }
        //    else
        //    {
        //        MessageBox.Show("data hasnot been Update");
        //    }
        //}
    }
}
