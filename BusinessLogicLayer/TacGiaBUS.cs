using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class TacGiaBUS
    {
        //Kiểm tra chuỗi id nhập vào
        public bool checkId(string id)
        {
            if (id.Length == 7)
                return true;
            return false;
        }
        //Check
        public bool checkTG(string matg)
        {
            TacGiaDAL tg = new TacGiaDAL();
            List<TACGIA> list = new List<TACGIA>();
            list = tg.getTacGia();
            foreach (var i in list)
            {
                if (i.MATG == matg)
                    return true;
            }
            return false;
        }
        //Lấy
        public DataTable getTG()
        {
            TacGiaConnection db = new TacGiaConnection();
            var tgia = from tg in db.TACGIAs select tg;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã tác giả");
            dt.Columns.Add("Tên tác giả");
            dt.Columns.Add("Năm sinh");
            dt.Columns.Add("Năm mất");
            dt.Columns.Add("Quên quán");

            foreach (var i in tgia)
            {
                dt.Rows.Add(i.MATG,i.TENTG,i.NAMSINH,i.NAMMAT,i.QUEQUAN);
            }

            return dt;
        }
        //Thêm
        public bool ThemTacGia(string matg, string tentg, string namsinh, string nammat, string que, ref string err)
        {
            TacGiaConnection db = new TacGiaConnection();
            TACGIA tg = new TACGIA();
            tg.MATG = matg;
            tg.TENTG = tentg;
            tg.NAMSINH = Convert.ToDateTime(namsinh);
            tg.NAMMAT = Convert.ToDateTime(nammat);
            tg.QUEQUAN = que;

            db.TACGIAs.Add(tg);
            db.SaveChanges();
            return true;
        }
        //Xóa
        public bool XoaTacGia(string matg, ref string err)
        {
            TacGiaConnection db = new TacGiaConnection();
            TACGIA tg = new TACGIA();
            tg.MATG = matg;

            db.TACGIAs.Attach(tg);
            db.TACGIAs.Remove(tg);

            db.SaveChanges();
            return true;
        }
        //Sửa
        public bool SuaTacGia(string matg, string tentg, string namsinh, string nammat, string que, ref string err)
        {
            TacGiaConnection tacgia = new TacGiaConnection();
            var tgQuery = (from tg in tacgia.TACGIAs
                           where tg.MATG == matg
                           select tg).SingleOrDefault();
            if (tgQuery != null)
            {
                tgQuery.TENTG = tentg;
                tgQuery.NAMSINH = Convert.ToDateTime(namsinh);
                tgQuery.NAMMAT = Convert.ToDateTime(nammat);
                tgQuery.QUEQUAN = que;
                tacgia.SaveChanges();
            }
            return true;
        }
    }
}
