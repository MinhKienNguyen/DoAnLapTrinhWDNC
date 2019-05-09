using GiaoDien.Controllers;
using System.Data;

namespace GiaoDien.Models
{
    public class LoginModel
    {
        LoginControllers _loginControllers = new LoginControllers();
        public DataTable GetDataLogin(string pUser, string pPass)
        {
            return _loginControllers.GetDataLogin(pUser, pPass);
        }
    }
}
