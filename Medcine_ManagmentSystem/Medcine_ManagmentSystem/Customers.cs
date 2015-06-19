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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }



        private void frmCustomer_Load(object sender, EventArgs e)
        {
             getCustomerData();
        }
        
        private void getCustomerData()
        {
            dgvCustomer.DataSource = Customer.getTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Customer.Insert(Convert.ToInt32(txtCustomerID.Text), txtCustomerName.Text, txtCustomerAddress.Text, txtCustomerPhone.Text, txtCustomerDescriotion.Text))
            {
                ntfCustomer.ShowBalloonTip(300, "Insertion in CustomerDataTable", "Data has been successfully loaded", ToolTipIcon.Info);
                getCustomerData();
            }
            else
            {
                ntfCustomer.ShowBalloonTip(300, "Insertion in CustomerDataTable", "Data has been Failed", ToolTipIcon.Error);
                getCustomerData();
            }
            TextClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Customer.Insert(Convert.ToInt32(txtCustomerID.Text), txtCustomerName.Text, txtCustomerAddress.Text, txtCustomerPhone.Text, txtCustomerDescriotion.Text))
            {
                ntfCustomer.ShowBalloonTip(300, "Updation in CustomerDataTable", "Data has been successfully Update", ToolTipIcon.Info);
                getCustomerData();
            }
            else
            {
                ntfCustomer.ShowBalloonTip(300, "UPdation in CustomerDataTable", "Data has been Failed", ToolTipIcon.Error);
                getCustomerData();
            }
            TextClear();
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Customer.Delete(Convert.ToInt32(txtCustomerID.Text)))
            {
                ntfCustomer.ShowBalloonTip(300, "Delete Succeeded", "RECORD Delete Successfully", ToolTipIcon.Info);
                getCustomerData();
            }
            else
            {
                ntfCustomer.ShowBalloonTip(300, "Updateting Failed", "Recored Insertion Failed ", ToolTipIcon.Error);
            }
            TextClear();

        }
        public void TextClear()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerDescriotion.Clear();
            txtCustomerAddress.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            TextClear();
        
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }
 
        


    }
}
