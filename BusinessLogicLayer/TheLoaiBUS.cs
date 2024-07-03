using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class TheLoaiBUS
    {
        //Check
        public bool checkTheLoai(string name)
        {
            TheLoaiDAL tl = new TheLoaiDAL();
            List<LOAISACH> list = new List<LOAISACH>();
            list = tl.getTheLoai();
            foreach (var i in list)
            {
                if (i.IDSACH == name)
                    return true;
            }
            return false;
        }

        //Lấy
        public DataTable getLoaiToDGV()
        {
            TheLoaiConnection db = new TheLoaiConnection();
            var loai = from lo in db.LOAISACHes select lo;

            DataTable dt = new DataTable();
            dt.Columns.Add("Loại sách");

            foreach (var i in loai)
            {
                dt.Rows.Add(i.TENLOAISACH);
            }
            return dt;
        }
        //Thêm
        public bool ThemLoaiSach(string mals, string tenLS)
        {
            TheLoaiConnection db = new TheLoaiConnection();
            LOAISACH lo = new LOAISACH();
            lo.IDSACH = mals;
            lo.TENLOAISACH = tenLS;

            db.LOAISACHes.Add(lo);
            db.SaveChanges();
            return true;
        }
        //Xóa
        public bool XoaLoaiSach(ref string err, string tenLS)
        {
            TheLoaiConnection db = new TheLoaiConnection();
            LOAISACH lo = new LOAISACH();
            lo.IDSACH = tenLS;

            db.LOAISACHes.Attach(lo);
            db.LOAISACHes.Remove(lo);
            db.SaveChanges();
            return true;
        }
    }
}
