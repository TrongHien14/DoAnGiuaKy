using DoAnGiuaKy.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace DoAnGiuaKy.Controllers
{
    public class NhaSXController : Controller
    {
        // GET: NhaSX
        public ActionResult Index(String id, int page = 1, int pagesize = 3)
        {
            var nsx = NhaSXBUS.ChiTietNSX(id).ToPagedList(page, pagesize);
            return View(nsx);
        }
    }
}