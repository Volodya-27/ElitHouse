using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication17.Data.Models;
using WebApplication17.Interfaces;

namespace WebApplication17.Controllers
{
    public class Home1Controller : Controller
    {
        private readonly IHouseData houseData;

        public Home1Controller(IHouseData _houseData)
        {
            houseData = _houseData;
        }

        public IActionResult Allview()
        {
            return View(houseData.GetHouse());
        }

        [HttpGet]
        //[Authorize]
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult DeleteHouseDb()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteHouse(int Id)
        {
            houseData.RemoveHouse(Id);
            return Redirect("~/");
        }



        [HttpPost]
        public IActionResult GetDataFromViewField(string _Decs, string _Img)
        {
            var house1 = new House()
            {
                Desc = _Decs,
                Img = _Img
            };
            houseData.AddHouse(house1);
            return Redirect("~/");
        }
    }
}
