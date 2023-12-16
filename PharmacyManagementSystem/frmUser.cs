using PharmacyManagementSystem.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem
{
    public partial class frmUser : Form
    {
        String user = "";
        public frmUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public frmUser(String userName)
        {
            InitializeComponent();
            lblUserName.Text = userName;
            user = userName;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            uS_DashBoard1.Visible = true;
            uS_DashBoard1.BringToFront();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            uS_DashBoard1.Visible = false;
            uS_AddMedicine1.Visible = false;
            uS_ViewMedicine1.Visible = false;
            uS_Update_Medicine1.Visible = false;
            uS_ViewCheckValidity1.Visible = false;
            btnDashBoard.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uS_AddMedicine1.Visible = true;
            uS_AddMedicine1.BringToFront();
        }

        private void uS_AddMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uS_ViewMedicine1.Visible = true;
            uS_ViewMedicine1.BringToFront();
        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            uS_Update_Medicine1.Visible=true;
            uS_Update_Medicine1.BringToFront();
        }

        private void btnMedicineValidityCheck_Click(object sender, EventArgs e)
        {
            uS_ViewCheckValidity1.Visible=true;
            uS_ViewCheckValidity1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uS_SellMedicine1.Visible = true;
            uS_SellMedicine1.BringToFront();
        }
    }
}
