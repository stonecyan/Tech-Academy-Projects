using CarInsuranceApp.Models;
using CarInsuranceApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities1 db = new CarInsuranceEntities1())
            {
                var quotes = db.CarInsurances.ToList();
                var quotelist = new List<QuoteVm>();

                foreach (var x in quotes)
                {
                    var carquote = new QuoteVm();
                    carquote.Id = x.Id;
                    carquote.FirstName = x.FirstName;
                    carquote.LastName = x.LastName;
                    carquote.EmailAddress = x.EmailAddress;
                    carquote.FullQuote = x.FullQuote;
                    carquote.LiabilityQuote = x.LiabilityQuote;
                    quotelist.Add(carquote);
                }

                return View(quotelist);
            }
            
        }
    }
}