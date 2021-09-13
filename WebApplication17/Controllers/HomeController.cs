using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.DataBase;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()=>View();
        public IActionResult Allview()
        {
            ViewBag.Houses = new DataContext().Houses/*.Where(a=>a.Id==2)*/; //comment SQL Linq for example
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDataFromViewField(string _Decs, string _Img)
        {
            using (var db = new DataContext())
            {
                db.Houses.Add(
                    new Data.Models.House()
                    {
                        Desc = _Decs,
                        Img = _Img
                        
                    });

                db.SaveChanges();
            }
            return Redirect("~/");
        }
    }
}
