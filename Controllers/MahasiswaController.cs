using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkshopASPCore21.DAL;
using WorkshopASPCore21.Models;

namespace WorkshopASPCore21.Controllers
{
    public class MahasiswaController : Controller
    {
        private IMahasiswa _mhs;
        public MahasiswaController(IMahasiswa mhs)
        {
            _mhs = mhs;
        }
        public IActionResult Index(){
            var models = _mhs.GetAll();
            return View(models);
        }
    }
}