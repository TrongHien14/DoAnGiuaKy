using ShopDienThoaiTCnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKy.Models.BUS
{
    public class ShopDienThoaiBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopDienThoaiTCntDB();
            return db.Query<SanPham>("SELECT * FROM SanPham WHERE TinhTrang = 0");
        }

        public static SanPham ChiTietSP(String sp)
        {
            var db = new ShopDienThoaiTCntDB();
            return db.SingleOrDefault<SanPham>("SELECT * FROM SanPham WHERE MaSanPham = @0",sp);
        }
    }
}