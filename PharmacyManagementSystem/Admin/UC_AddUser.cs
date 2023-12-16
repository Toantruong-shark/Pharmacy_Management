using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.Admin
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtRole.Text != "" && txtName.Text != "" && txtDate.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                String role = txtRole.Text;
                String name = txtName.Text;
                String dob = txtDate.Text;
                Int64 mobile = Int64.Parse(txtPhone.Text);
                String email = txtEmail.Text;
                String username = txtUserName.Text;
                String pass = txtPassword.Text;

                try
                {
                    query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + pass + "')";
                    fn.setData(query, "Sign up successful.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Username Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDate.ResetText();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtRole.SelectedIndex=-1;
            txtUserName.Clear();

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query= "select * from users where username = '" + txtUserName.Text +"'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictrAddUser.ImageLocation = @"C:\Users\ASUS\Downloads\BaoCaoCuoiKy\PharmacyManagementSystem\PharmacyManagementSystem\image_pharmacy\image_pharmacy\\yes.png";
            }
            else
            {
                pictrAddUser.ImageLocation = @"C:\Users\ASUS\Downloads\BaoCaoCuoiKy\PharmacyManagementSystem\PharmacyManagementSystem\image_pharmacy\image_pharmacy\no.png";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string input = txtPhone.Text;

            // Kiểm tra nếu input không phải là số
            if (!int.TryParse(input, out _))
            {
                MessageBox.Show("Chỉ nhập các số, không nhập các ký tự khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Xóa các ký tự không phải số
                txtPhone.Text = new string(input.Where(char.IsDigit).ToArray());
            }
        }

        private void pictrAddUser_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
