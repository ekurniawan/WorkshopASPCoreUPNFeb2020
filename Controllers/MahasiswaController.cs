using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkshopASPCore21.Models;

namespace WorkshopASPCore21.Controllers
{
    public class MahasiswaController : Controller
    {
        public IActionResult Index(){
            List<Mahasiswa> lstMhs = new List<Mahasiswa>{
                new Mahasiswa {
                    Nim = "72348787",
                    Nama = "Erick Kurniawan",
                    IPK=3.2,
                    Email="erick.kurniawan@gmail.com"
                },
                new Mahasiswa {
                    Nim = "71098787",
                    Nama = "Andi Handoyo",
                    IPK = 3.5,
                    Email = "andy@gmail.com"
                },
                new Mahasiswa{
                    Nim = "73987878",
                    Nama = "Budi Sutedjo",
                    IPK = 3.2,
                    Email = "budi@gmail.com"
                }
            };

            return View(lstMhs);
        }
    }
}