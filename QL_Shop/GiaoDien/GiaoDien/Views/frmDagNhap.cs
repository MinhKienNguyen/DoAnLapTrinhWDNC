using DevExpress.XtraEditors;
using GiaoDien.DoMain;
using GiaoDien.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class frmDagNhap : DevExpress.XtraEditors.XtraForm
    {
        LoginModel _loginModel = new LoginModel();
        public frmDagNhap()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable table = _loginModel.GetDataLogin(txttaikhoan.Text, txtmk.Text);
            
            if(table == null || table.Rows.Count <= 0)
            {
                XtraMessageBox.Show(Commons.LoginError,Commons.Notify, MessageBoxButtons.OKCancel);
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain();
            }
            Program.mainForm.TenNhanVien = table.Rows[0]["TenNhanVien"].ToString();
            this.Hide();
            Program.mainForm.Show();
        }
    }
}