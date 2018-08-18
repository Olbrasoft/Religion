using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olbrasoft.Religion.Mvc.Models;

namespace Olbrasoft.Religion.Mvc.Controllers
{

    //todo How change in Visual Studio DefaultController to HomeController
    public class HomeController : ReligionController
    {
        private IReligionsFacade facade;

        public HomeController(IReligionsFacade facade)
        {
            this.facade = facade;
        }

        // GET: Home
        public ActionResult Index()
        {
            var religions = new ReligionDataTransferObject[1];
            
            //return View;
            return View(religions);
        }
    }
}