using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KhoDAL
    {
        public List<KHO> getKho()
        {
            List<KHO> dsAccount = new List<KHO>();
            using (KhoConnection db = new KhoConnection())
            {
                var dsAcc = from acc in db.KHOes
                            select acc;
                foreach (var i in dsAcc)
                {
                    KHO acc = new KHO();
                    acc.MASACH = i.MASACH;
                    acc.SOLUONG = i.SOLUONG;

                    dsAccount.Add(acc);
                }
            }
            return dsAccount;
        }
    }
}
