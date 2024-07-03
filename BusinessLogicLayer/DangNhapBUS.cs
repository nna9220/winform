using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class DangNhapBUS
    {
        public bool checkTaiKhoan(string name, string pass)
        {
            DangNhapDAL dn = new DangNhapDAL();
            List<TAIKHOAN> list = new List<TAIKHOAN>();
            list = dn.getTaiKhoan();
            foreach (var i in list)
            {
                if (i.USERNAME == name && i.PASS_WORD == pass)
                    return true;
            }
            return false;
        }
        public bool themTaiKhoan(string name, string pass)
        {
            DangNhapConnection db = new DangNhapConnection();
            TAIKHOAN tk = new TAIKHOAN();
            tk.USERNAME = name;
            tk.PASS_WORD = pass;

            db.TAIKHOANs.Add(tk);
            db.SaveChanges();
            return true;
        }

    }
}
