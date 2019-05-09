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
using GiaoDien.Models;

namespace GiaoDien.Views
{
    public partial class UC_PhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        NhanvienModel _nhanvienModel = new NhanvienModel();
        PhanQuyenModel _phanQuyenModel = new PhanQuyenModel();
        public UC_PhanQuyen()
        {
            InitializeComponent();
        }

        public void LoadGridNhomND()
        {
            DataTable dt = _phanQuyenModel.GetDataNhomND();
            grdNhomND.DataSource = dt;
        }
    }
}
