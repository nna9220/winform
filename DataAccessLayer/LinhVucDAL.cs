using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
namespace DataAccessLayer
{
    public class LinhVucDAL
    {
        public List<LINHVUC> getLinhVuc()
        {
            List<LINHVUC> dsLV = new List<LINHVUC>();
            using (LinhVucConnection db = new LinhVucConnection())
            {
                var dslv = from lv in db.LINHVUCs
                           select lv;
                foreach (var i in dslv)
                {
                    LINHVUC lv = new LINHVUC();
                    lv.TENLINHVUC = i.TENLINHVUC;
                    dsLV.Add(lv);
                }
            }
            return dsLV;
        }
    }
}
