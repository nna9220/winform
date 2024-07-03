using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using System.Data.Entity;
namespace BusinessLogicLayer
{
    public class LinhVucBUS
    {
        //Kiểm tra chuỗi id nhập vào
        public bool checkId(string id)
        {
            if (id.Length == 7)
                return true;
            return false;
        }
        //Check
        public bool checkLinhVuc(string ten)
        {
            LinhVucDAL nv = new LinhVucDAL();
            List<LINHVUC> list = new List<LINHVUC>();
            list = nv.getLinhVuc();
            foreach (var i in list)
            {
                if (i.ID == ten)
                    return true;
            }
            return false;
        }
        public DataTable getLinhVucToDGV()
        {
            LinhVucConnection db = new LinhVucConnection();
            var linh_vuc = from lv in db.LINHVUCs select lv;

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Lĩnh vực sách");

            foreach (var i in linh_vuc)
            {
                dt.Rows.Add(i.ID, i.TENLINHVUC);
            }

            return dt;
        }
        public List<LINHVUC> fillComboBox()
        {
            LinhVucConnection db = new LinhVucConnection();
            List<LINHVUC> tenLV = (from lv in db.LINHVUCs select lv).Take(1).ToList();

            return tenLV;
        }
        public bool ThemLinhVuc(string tenLV, string malv)
        {
            LinhVucConnection db = new LinhVucConnection();
            LINHVUC lv = new LINHVUC();
            lv.TENLINHVUC = tenLV;
            lv.ID = malv;

            db.LINHVUCs.Add(lv);
            db.SaveChanges();
            return true;
        }
        public bool XoaLinhVuc(ref string err, string tenLV)
        {
            LinhVucConnection db = new LinhVucConnection();
            LINHVUC lv = new LINHVUC();
            lv.ID = tenLV;

            db.LINHVUCs.Attach(lv);
            db.LINHVUCs.Remove(lv);

            db.SaveChanges();
            return true;
        }
    }
}

