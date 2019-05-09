using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class NguoiDungNhomNgDungModel
    {
        NguoiDungNhomNgDungControllers _nguoiDungNhomNgDungControllers = new NguoiDungNhomNgDungControllers();

        /// <summary>
        /// GetNhomND -- Load lưới bên trái
        /// </summary>
        /// <returns></returns>
        public DataTable GetNhomND()
        {
            return _nguoiDungNhomNgDungControllers.GetNhomND();
        }

        /// <summary>
        /// GetNgDNhomND -- Load lưới bên phải
        /// </summary>
        /// <param name="maNhom"></param>
        /// <returns></returns>
        public DataTable GetNgDNhomND(string maNhom)
        {
            return _nguoiDungNhomNgDungControllers.GetNgDNhomND(maNhom);
        }

        public DataTable InsertNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _nguoiDungNhomNgDungControllers.InsertNguoiDungNhomNgDung(maNhom, user);
        }

        public DataTable DeleteNguoiDungNhomNgDung(string maNhom, string user)
        {
            return _nguoiDungNhomNgDungControllers.DeleteNguoiDungNhomNgDung(maNhom, user);
        }
    }
}
