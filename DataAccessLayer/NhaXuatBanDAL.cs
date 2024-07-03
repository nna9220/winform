using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhaXuatBanDAL
    {
        public List<NHAXUATBAN> getNXB()
        {
            List<NHAXUATBAN> dsNXB = new List<NHAXUATBAN>();
            using (NhaXuatBanConnection db = new NhaXuatBanConnection())
            {
                var dsnxb = from nv in db.NHAXUATBANs
                           select nv;
                foreach (var i in dsnxb)
                {
                    NHAXUATBAN nxb = new NHAXUATBAN();
                    nxb.TENNHAXUATBAN = i.TENNHAXUATBAN;
                    dsNXB.Add(nxb);
                }
            }
            return dsNXB;
        }
    }
}
