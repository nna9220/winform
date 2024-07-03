using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TheLoaiDAL
    {
        public List<LOAISACH> getTheLoai()
        {
            List<LOAISACH> dsLS = new List<LOAISACH>();
            using (TheLoaiConnection db = new TheLoaiConnection())
            {
                var dsls = from ls in db.LOAISACHes
                           select ls;
                foreach (var i in dsls)
                {
                    LOAISACH ls = new LOAISACH();
                    ls.TENLOAISACH = i.TENLOAISACH;
                    dsLS.Add(ls);
                }
            }
            return dsLS;
        }
    }
}
