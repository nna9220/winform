using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SachDAL
    {
        public List<SACH> getSach()
        {
            List<SACH> dsS = new List<SACH>();
            using (SachConnection db = new SachConnection())
            {
                var dss = from s in db.SACHes
                           select s;
                foreach (var i in dss)
                {
                    SACH s = new SACH();
                    s.MASACH = i.MASACH;
                    s.TENSACH = i.TENSACH;
                    s.MATG = i.MATG;
                    s.TENLINHVUC = i.TENLINHVUC;
                    s.TENLOAISACH = i.TENLOAISACH;
                    s.GIAMUA = i.GIAMUA;
                    s.GIABIA = i.GIABIA;
                    s.LANTAIBAN = i.LANTAIBAN;
                    s.TENNHAXUATBAN = i.TENNHAXUATBAN;
                    s.NAMXUATBAN = i.NAMXUATBAN;
                    dsS.Add(s);
                }
            }
            return dsS;
        }
    }
}
