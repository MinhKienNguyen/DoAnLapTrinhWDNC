using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class PhanQuyenModel
    {
        PhanQuyenControllers _phanQuyenControllers = new PhanQuyenControllers();
        public DataTable GetDataNhomMangHinh(string maNhom)
        {
            return _phanQuyenControllers.GetDataNhomMangHinh(maNhom.ToString());
        }

        public DataTable GetDataNhomND()
        {
            return _phanQuyenControllers.GetDataNhomND();
        }
    }
}
