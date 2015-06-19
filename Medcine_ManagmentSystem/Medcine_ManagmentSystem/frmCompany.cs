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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            getCompanyData();
        }
        private void getCompanyData()
        {
            dgvCompany.DataSource = Company.getTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Company.Insert(Convert.ToInt32(txtCompanyId.Text), txtCName.Text, txtCompanyAddress.Text, txtCPhoneNo.Text))
            {
                ntfCompany.ShowBalloonTip(300, "Insertion Succeeded", "Record Inserted Successfully", ToolTipIcon.Info);
                getCompanyData();
            }
            else
            {
                ntfCompany.ShowBalloonTip(300, "Insertion Failed", "Recored Insertion Failed ", ToolTipIcon.Error);
            }
            TextClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Company.Update(Convert.ToInt32(txtCompanyId.Text),txtCName.Text,txtCompanyAddress.Text,txtCPhoneNo.Text))
            {
                ntfCompany.ShowBalloonTip(300, "Updateting Succeeded", "Recored Update Successfully ", ToolTipIcon.Info);
                getCompanyData();
            }
            else
            {
                ntfCompany.ShowBalloonTip(300, "Updateting Failed", "Recored Insertion Failed ", ToolTipIcon.Error);
            }
            TextClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Company.Delete(Convert.ToInt32(txtCompanyId.Text), txtCName.Text, txtCompanyAddress.Text, txtCPhoneNo.Text))
            {
                ntfCompany.ShowBalloonTip(300, "Delete Succeeded", "RECORD Delete Successfully", ToolTipIcon.Info);
                getCompanyData();
            }
            else
            {
                ntfCompany.ShowBalloonTip(300, "Updateting Failed", "Recored Insertion Failed ", ToolTipIcon.Error);
            }
            TextClear();
        }

        public void TextClear()
        {
            txtCPhoneNo.Clear();
            txtCompanyId.Clear();
            txtCompanyAddress.Clear();
            txtCName.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            TextClear();
        }

        private void txtCompanyId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (! char.IsDigit(e.KeyChar))&& e.KeyChar !=(char) Keys.Back )
            {
                e.Handled = true;
            }
            
        }

        private void txtCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }



    }
}
