using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
namespace DataAccessLayer
{
    public class TacGiaDAL
    {
        public List<TACGIA> getTacGia()
        {
            List<TACGIA> dsTG = new List<TACGIA>();
            using (TacGiaConnection db = new TacGiaConnection())
            {
                var dstg = from tg in db.TACGIAs
                           select tg;
                foreach (var i in dstg)
                {
                    TACGIA tg = new TACGIA();
                    tg.MATG = i.MATG;
                    tg.TENTG = i.TENTG;
                    tg.NAMSINH = i.NAMSINH;
                    tg.NAMMAT = i.NAMMAT;
                    tg.QUEQUAN = i.QUEQUAN;
                    dsTG.Add(tg);
                }
            }
            return dsTG;
        }
    }
}
