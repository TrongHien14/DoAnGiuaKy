using ShopDienThoaiTCnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKy.Models.BUS
{
    public class NhaSXBUS
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var db = new ShopDienThoaiTCntDB();
            return db.Query<NhaSanXuat>("SELECT * FROM NhaSanXuat WHERE TinhTrang = 0");
        }
        public static IEnumerable<SanPham> ChiTietNSX(String id)
        {
            var db = new ShopDienThoaiTCntDB();
            return db.Query<SanPham>("SELECT * FROM SanPham WHERE MaNhaSanXuat = '"+id+ "'");
        }
    }
}