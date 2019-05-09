using GiaoDien.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Models
{
    public class MangHinhModel
    {
        MangHinhControllers _mangHinhControllers = new MangHinhControllers();
        public DataTable GetData(string pMaMH)
        {
            return _mangHinhControllers.GetData(pMaMH);
        }
    }
}
