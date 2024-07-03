using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace DataAccessLayer
{
    public class DangNhapDAL
    {
        public List<TAIKHOAN> getTaiKhoan()
        {
            List<TAIKHOAN> dsAccount = new List<TAIKHOAN>();
            using (DangNhapConnection db = new DangNhapConnection())
            {
                var dsAcc = from acc in db.TAIKHOANs
                            select acc;
                foreach (var i in dsAcc)
                {
                    TAIKHOAN acc = new TAIKHOAN();
                    acc.USERNAME = i.USERNAME;
                    acc.PASS_WORD = i.PASS_WORD;

                    dsAccount.Add(acc);
                }
            }
            return dsAccount;
        }
    }
}
