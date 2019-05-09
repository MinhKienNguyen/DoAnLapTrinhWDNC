using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{
    public class PhanQuyenControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetDataNhomMangHinh(string maNhom)
        {
            return _unity.filldb("QL_PhanQuyen_GetData", maNhom.ToString());
        }

        public DataTable GetDataNhomND()
        {
            return _unity.filldb("QL_NhomNguoiDung_GetData");
        }
    }
}
