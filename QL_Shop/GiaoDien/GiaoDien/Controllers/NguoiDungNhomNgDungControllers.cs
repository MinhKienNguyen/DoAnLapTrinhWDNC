using GiaoDien.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Controllers
{

    public class NguoiDungNhomNgDungControllers
    {
        UnityClass _unity = new UnityClass();
        public DataTable GetNhomND()
        {
            return _unity.filldb("QL_TaiKhoan_GetData");
        }

        public DataTable GetNgDNhomND(string maNhom)
        {
            return _unity.filldb("QL_NguoiDungNhomNguoiDung_GetData", maNhom.ToString());
        }

        public DataTable InsertNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _unity.filldb("QL_NguoiDungNhomNguoiDung_InsertOrUpdate", maNhom.ToString(), user.ToString());
        }

        public DataTable DeleteNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _unity.filldb("QL_NguoiDungNhomNguoiDung_Delete", maNhom.ToString(), user.ToString());
        }
    }
}
