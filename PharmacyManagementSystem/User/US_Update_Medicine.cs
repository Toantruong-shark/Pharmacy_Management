using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.User
{
    public partial class US_Update_Medicine : UserControl
    {
        function fn = new function();
        String query;
        public US_Update_Medicine()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtmDate.ResetText();
            txteDate.ResetText();
            txtAddQuantity.Clear();
            txtAvailableQuantity.Clear();
            txtPricePerunit.Clear();

            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }
        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediName.Text;
            String mnumber = txtMediNumber.Text;
            String mdate = txtmDate.Value.ToShortDateString();
            String edate = txteDate.Value.ToShortDateString();
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerunit.Text);    

            totalQuantity= quantity +addQuantity;

            query = "update medic set mname =N'" +mname+"',mnumber= '"+mnumber+"',mDate= '"+mdate+"',eDate='"+edate+ "',quantity = '" +totalQuantity+"',perUnit='"+unitprice+"' where mid = '"+txtMediID.Text+"'";
            fn.setData(query, "Đã cập nhật chi tiết thuốc");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != ""){
                query = "select * from medic where mid='" + txtMediID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count !=0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMediNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtmDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txteDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerunit.Text = ds.Tables[0].Rows[0][7].ToString();
                }else
                {
                    MessageBox.Show("Không có thuốc với ID này : " + txtMediID, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }else
            {
                clearAll();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void US_Update_Medicine_Load(object sender, EventArgs e)
        {

        }
    }
}
