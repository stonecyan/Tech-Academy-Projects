using CarInsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceApp.Controllers
{
    public class HomeController : Controller
    {
        bool flag = false;
        public ActionResult Index()
        {
            ViewBag.flagvalue = flag;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstName, string lastName, string emailAddress, DateTime DOB, int CarYear, string CarMake, string CarModel, string DUI, string Tickets, string coverage)
        {
            flag = true;
            ViewBag.flagvalue = flag;
            double quote = 50;
            int year = DateTime.Now.Year;
            int useryear = DOB.Year;
            int age = year - useryear;
            if (age<25 && age>=18 || age>100 )
            {
                quote += 25;
            }
            else if (age<18)
            {
                quote += 100;
            }
            if (CarYear<2000)
            {
                quote += 25;
            }
            else if (CarYear>2015)
            {
                quote += 25;
            }
            
            string carmodel = CarModel.ToLower();
            string carmake = CarMake.ToLower();
            if (carmake == "porsche")
            {
                quote += 25;
                if (carmodel=="911 carrera")
                {
                    quote += 25;
                }
            }
            quote += Convert.ToInt32(Tickets) * 10;

            string dui = DUI.ToLower();
            if (dui=="yes")
            {
                quote = quote * 1.25;
            }

            double fullquote = quote*1.5;
            double liabilityquote = quote;
            string Coverage = Request.Form["coverage"];

            if (Coverage == "full")
            {
                quote = fullquote;
            }
            else
            {
                quote = liabilityquote;
            }

            ViewBag.quote = quote;

            using (CarInsuranceEntities1 db = new CarInsuranceEntities1())
            {
                var carinsurance = new CarInsurance();

                carinsurance.FirstName = firstName;
                carinsurance.LastName = lastName;
                carinsurance.EmailAddress = emailAddress;
                carinsurance.DOB = DOB.ToString();
                carinsurance.CarYear = CarYear.ToString();
                carinsurance.CarMake = CarMake;
                carinsurance.CarModel = CarModel;
                carinsurance.DUI = DUI;
                carinsurance.Ticket = Tickets;
                carinsurance.Coverage = Coverage;
                carinsurance.FullQuote = fullquote.ToString();
                carinsurance.LiabilityQuote = liabilityquote.ToString();

                db.CarInsurances.Add(carinsurance);
                db.SaveChanges();


            }

            return View();
                


        }
    }
}