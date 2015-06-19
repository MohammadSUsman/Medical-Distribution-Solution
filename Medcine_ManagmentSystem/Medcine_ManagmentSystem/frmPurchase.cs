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
    public partial class frmPurchase : Form
    {
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            getPurchaseData();
            cmbCompanyId.DataSource = Company.getTable();
            cmbCompanyId.DisplayMember = "CompanyName";
            cmbCompanyId.ValueMember = "CompanyID";

            cmbMedicineName.DataSource = Medicine.getTable();
            cmbMedicineName.DisplayMember = "MedicineName";
            cmbMedicineName.ValueMember = "MedicineName";
        }
        private void getPurchaseData()
        {
            dgvPurchase.DataSource = Purches.getTable();
             dgvPurchase.DataSource = PurchesDetails.getTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!(Purches.FrindRow(txtPurchaseID.Text)))
            {
                 if(!(Purches.Insert(Convert.ToInt32( txtPurchaseID.Text),Convert.ToDateTime(dtpPurchase.Text),Convert.ToInt32(cmbCompanyId.SelectedValue.ToString ()))))
                 {
                     MessageBox.Show("Purchase Insertion FAiled");
                 }
            }
           if (PurchesDetails.Insert(Convert.ToInt32(txtPurchaseID.Text),cmbMedicineName.Text ,Convert.ToInt32(txtQuantity.Text),Convert.ToInt32(txtDiscount.Text ),Convert.ToInt32(txtPrice.Text )))
           {
               ntfPurchase.ShowBalloonTip(300,"Insertion Succeeded","Product Inserted Successfully",ToolTipIcon.Info);
           }
           else
           {
               MessageBox.Show ("PUrchase Detail Insertion failed ");
           }
           dgvPurchase.DataSource = PurchesDetails.getTableWithId(txtPurchaseID.Text);
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtQuantity.Text = dgvPurchase.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiscount.Text = dgvPurchase.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = dgvPurchase.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbMedicineName.Text = dgvPurchase.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (PurchesDetails.Update(Convert.ToInt32(txtPurchaseID.Text), cmbMedicineName.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToInt32(txtDiscount.Text), Convert.ToInt32(txtPrice.Text)))
            {
                ntfPurchase.ShowBalloonTip(300, "Updated Successfully", cmbMedicineName.Text + " Updated Successfull", ToolTipIcon.Info);
                dgvPurchase.DataSource = PurchesDetails.getTableWithId(txtPurchaseID.Text);
            }
            else
            {
                MessageBox.Show("Updation Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PurchesDetails.Delete(Convert.ToInt32(txtPurchaseID.Text), cmbMedicineName.Text))
            {
                ntfPurchase.ShowBalloonTip(300, "Deleted Successfully", cmbMedicineName.Text + " Deleted Successfully", ToolTipIcon.Info);
                dgvPurchase.DataSource = PurchesDetails.getTableWithId(txtPurchaseID.Text);
            }
            else
            {
                MessageBox.Show("Deletion Failed ");
            }
        }

        private void DataClear()
        {
            txtPurchaseID.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();
            txtDiscount.Clear();
            txtPrice.Clear();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            DataClear();

        }
    }
}
