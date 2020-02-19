using System;
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

        public IActionResult Details(string id){
            var model = _mhs.GetById(id);
            return View(model);
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mahasiswa mhs){
            try{
                _mhs.Insert(mhs);
                return RedirectToAction("Index");
            }catch(Exception ex){
                ViewBag.Pesan = $"<span class='alert alert-danger'>{ex.Message}</span>";
            }
            return View();
        }
    }
}