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
    public partial class frmMedicine : Form
    {
        public frmMedicine()
        {
            InitializeComponent();
        }


        private void frmMedicine_Load(object sender, EventArgs e)
        {
            getTableDataMedicine();
            cmbMedicine.DataSource = Company.getTable();
            cmbMedicine.DisplayMember = "CompanyName";
            cmbMedicine.ValueMember = "CompanyID";

           // cmbMedicineName.DataSource = PurchesDetails.getTable();
           // cmbMedicineName.DisplayMember = "MedicineName";
           // cmbMedicineName.ValueMember = "MedicineName";
        }
        private void getTableDataMedicine()
        {
            dgvMedicine.DataSource = MedicineDetails.getTable();
            //dgvMedicine.DataSource = Medicine.getTable();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
           //if(Medicine.getTable(txtMedicineName.Text).Rows.Count == 0)
           //{
            if (Medicine.Insert(txtMedicineName.Text, (txtSalt.Text), (Convert.ToInt32(txtStrength.Text)), (Convert.ToInt32(txtCompanyID.Text)), (txtMedicineType.Text)))
            {
                getTableDataMedicine();
                MessageBox.Show("inserted into medine");
            }
            else
            {
                MessageBox.Show("not inserted into medine");
                getTableDataMedicine();
            }
           //}

            if (MedicineDetails.getTable().Rows.Count == 0)
            {
                if (MedicineDetails.Insert(txtMedicineName.Text, (Convert.ToInt32(txtBatchNo.Text)), (Convert.ToDateTime(dtpMenufacture.Text)), (Convert.ToDateTime(dtpExpiry.Text)), (Convert.ToDecimal(txtPrice))))
                {
                    MessageBox.Show("inserted into medineDetails");

                    getTableDataMedicine();
                }
                else
                {
                    MessageBox.Show("not inserted into medinedetails");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if(Medicine.getTable(txtMedicineName.Text).Rows.Count == 0)
            //{
            if (Medicine.Update(txtMedicineName.Text, (txtSalt.Text), (Convert.ToInt32(txtStrength.Text)), (Convert.ToInt32(txtCompanyID.Text)), (txtMedicineType.Text)))
            {
                MessageBox.Show("Update");

                getTableDataMedicine();
            }
            //}
            else
            {
                MessageBox.Show("notupdate");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Medicine.Delete((txtMedicineName.Text),txtSalt.Text, (Convert.ToInt32(txtStrength.Text)), (Convert.ToInt32(txtCompanyID.Text)), (txtMedicineType.Text)))
            {
                MessageBox.Show("DELete");
                getTableDataMedicine();
            }
            else
            {
                MessageBox.Show("not deleted");
            }

        }
        private void ClearAll()
        {
            txtBatchNo.Clear();
            txtCompanyID.Clear();
            txtMedicineType.Clear();
            txtPrice.Clear();
            txtSalt.Clear();
            txtStrength.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtDiscount.Text = dgvSales.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBatchNo.Text = dgvMedicine.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCompanyID.Text = dgvMedicine.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMedicineType.Text= dgvMedicine.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrice.Text=dgvMedicine.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSalt.Text = dgvMedicine.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStrength.Text = dgvMedicine.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


    }
}
