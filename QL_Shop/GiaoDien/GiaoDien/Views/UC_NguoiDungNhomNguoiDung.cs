using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GiaoDien.Unity;
using GiaoDien.Models;
using GiaoDien.DoMain;

namespace GiaoDien.Views
{
    public partial class UC_NguoiDungNhomNguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        NhanvienModel _nhanvienModel = new NhanvienModel();
        NguoiDungNhomNgDungModel _ngDungModel = new NguoiDungNhomNgDungModel();
        private DataTable dtNgDNhomND = null;
        private DataTable dtTaiKhoan = null;
        public UC_NguoiDungNhomNguoiDung()
        {
            InitializeComponent();
            btnXoa.Click += BtnXoa_Click;
            btnChuyen.Click += BtnChuyen_Click;
        }

        private void BtnChuyen_Click(object sender, EventArgs e)
        {
            btnThem();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
            DataTable dtCheckInsert = _ngDungModel.DeleteNguoiDungNhomNgDung(row["MaNhom"].ToString(),row["Username"].ToString());
            if (dtCheckInsert.Rows.Count > 0 && Convert.ToInt16(dtCheckInsert.Rows[0][0].ToString()) > 0)
            {
                XtraMessageBox.Show(Commons.DeleteFinish, Commons.Notify, MessageBoxButtons.OK);
                LoadGridNND();
                return;
            }
            else
            {
                XtraMessageBox.Show(Commons.DeleteError, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
        }

        private void UC_NguoiDungNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadLookupDuty();
            LoadGridNhomND();
        }

        public void LoadLookupDuty()
        {
            DataTable dtDuty = _nhanvienModel.GetComboboxDuty();
            lkNhomQuyen.Properties.DataSource = dtDuty.Copy();
            lkNhomQuyen.Properties.ValueMember = "MaNhom";
            lkNhomQuyen.Properties.DisplayMember = "TenNhom";
        }

        public void LoadGridNhomND()
        {
            dtTaiKhoan = _ngDungModel.GetNhomND();
            gridControl1.DataSource = dtTaiKhoan.Copy();
        }

        public void LoadGridNND()
        {
            dtNgDNhomND = _ngDungModel.GetNgDNhomND(lkNhomQuyen.EditValue.ToString());
            grdNND.DataSource = dtNgDNhomND.Copy();
        }

        private void lkNhomQuyen_EditValueChanged(object sender, EventArgs e)
        {
            LoadGridNND();
        }

        private void btnThem()
        {
            DataRowView row = (DataRowView)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
            if(dtNgDNhomND == null || dtNgDNhomND.Rows.Count <= 0)
            {
                XtraMessageBox.Show(Commons.ChooseNhomND, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataRow[] drRows = this.dtNgDNhomND.Select("Username='" + row["Username"].ToString() + "'");
            if(drRows == null || drRows.Length <= 0)
            {
                DataTable dtCheckInsert = _ngDungModel.InsertNguoiDungNhomNgDung(lkNhomQuyen.EditValue.ToString(), row[1].ToString());
                if (dtCheckInsert.Rows.Count > 0 &&Convert.ToInt16(dtCheckInsert.Rows[0][0].ToString()) > 0)
                {
                    XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                    LoadGridNND();
                    return;
                }
                else
                {
                    XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);
                    return;
                }
            }
            XtraMessageBox.Show(Commons.Exist, Commons.Notify, MessageBoxButtons.OK);
        }
    }
}
