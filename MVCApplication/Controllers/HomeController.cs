using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        internal static Dictionary<string, string> columnChoices = new Dictionary<string, string>();


        public IActionResult Index()
        {

 

            return View();


        }

        public IActionResult Values(string column)
        {

            ValuesViewModel valuesViewModel = new ValuesViewModel();


            List<Dictionary<string, string>> elements = CSVData.FindAll();

            valuesViewModel.elements = elements;

            return View(valuesViewModel);
        }


        public IActionResult Results(string searchType, string searchTerm)

        {


            if (searchTerm != null)

            {
                List<Dictionary<string, string>> elements = CSVData.FindByValue(searchTerm);
                ViewBag.elements = elements;
                return View();


            }
                    

            return Redirect("/");
        }

    }

}
