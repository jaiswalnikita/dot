using Microsoft.AspNetCore.Mvc;
using Viewbeg_and_view_data.Models;

namespace Viewbeg_and_view_data.Controllers
{
    public class control : Controller
    {
        public IActionResult Index()
        {
            ViewBag.mydata = "NikitaJaiswal";
            ViewBag.mylist=new List<string>() { "Hello","Nikita"};
            List<Model> mlist = new List<Model>()
            {
                new Model(){ Firstname="Monti", Lastname="yadav", Email="asdfg"}
            };
            ViewBag.Modellist=mlist;
            return View();
        }
    }
}
