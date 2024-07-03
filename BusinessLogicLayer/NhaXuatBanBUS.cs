using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class NhaXuatBanBUS
    {
        public bool checkNXB(string name)
        {
            NhaXuatBanDAL nxb = new NhaXuatBanDAL();
            List<NHAXUATBAN> list = new List<NHAXUATBAN>();
            list = nxb.getNXB();
            foreach (var i in list)
            {
                if (i.TENNHAXUATBAN == name)
                    return true;
            }
            return false;
        }
        //lấy
        public DataTable getNhaXuatBan()
        {
            NhaXuatBanConnection db = new NhaXuatBanConnection();
            var nxb = from n in db.NHAXUATBANs select n;

            DataTable dt = new DataTable();
            dt.Columns.Add("Tên nhà xuất bản");

            foreach (var i in nxb)
            {
                dt.Rows.Add(i.TENNHAXUATBAN);
            }

            return dt;
        }
        //Thêm
        public bool themNXB(string name)
        {
            NhaXuatBanConnection db = new NhaXuatBanConnection();
            NHAXUATBAN nxb = new NHAXUATBAN();
            nxb.TENNHAXUATBAN = name;

            db.NHAXUATBANs.Add(nxb);
            db.SaveChanges();
            return true;
        }

        //Xóa
        public bool XoaNXB(string tennxb, ref string err)
        {
            NhaXuatBanConnection db = new NhaXuatBanConnection();
            NHAXUATBAN nxb = new NHAXUATBAN();
            nxb.TENNHAXUATBAN = tennxb;

            db.NHAXUATBANs.Attach(nxb);
            db.NHAXUATBANs.Remove(nxb);

            db.SaveChanges();
            return true;
        }
        //Sửa
    }
}
