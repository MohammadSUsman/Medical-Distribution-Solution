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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
//            getTableSales();
            cmbCustomerID.DataSource = Customer.getTable();
            cmbCustomerID.DisplayMember = "CustomerName";
            cmbCustomerID.ValueMember = "CustomerID";

            cmbProductName.DataSource = Medicine.getTable();
            cmbProductName.DisplayMember = "MedicineName";
            cmbProductName.ValueMember = "MedicineName";

        }
        private void getTableSales()
        {
            //dgvSales.DataSource = Medicine.getTable();
            //dgvSales.DataSource = Customer.getTable();
       //     dgvSales.DataSource = Sales.getTable();
            dgvSales.DataSource = SalesDetail.getTable(txtSaleID.Text);
           
        }
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (Sales.getTable(txtSaleID.Text).Rows.Count == 0)
            {
                if (Sales.Insert(Convert.ToInt32(txtSaleID.Text), Convert.ToDateTime(dtpSales.Text), Convert.ToInt32(cmbCustomerID.SelectedValue.ToString())))
                {
                    MessageBox.Show("inserted");
                    getTableSales();
                }
                else
                {
                    MessageBox.Show("not inserted");
                    getTableSales();

                }
            }
            if (SalesDetail.Insert(Convert.ToInt32(txtSaleID.Text), cmbProductName.Text, Convert.ToInt32(txtDiscount.Text), Convert.ToInt32(txtQuantity.Text), Convert.ToInt32(txtPrice.Text)))
            {
                getTableSales();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SalesDetail.Update(Convert.ToInt32(txtSaleID.Text), cmbProductName.Text, Convert.ToInt32(txtDiscount.Text) ,Convert.ToInt32(txtQuantity.Text), Convert.ToInt32(txtPrice.Text)))
            {
                MessageBox.Show("UPdate");
                getTableSales();
            }


        }

        private void txtSaleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (! char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsDigit (e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDiscount.Text = dgvSales.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSaleID.Text = dgvSales.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtQuantity.Text = dgvSales.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvSales.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbProductName.Text = dgvSales.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SalesDetail.Delete(Convert.ToInt32(txtSaleID.Text)))
            {
          //      MessageBox.Show("Delete");
                getTableSales();
               
            }
           
        }

        private void dataClear()
        {
            txtSaleID.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();
            txtPrice.Clear();
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataClear();
        }


        
    }
}
