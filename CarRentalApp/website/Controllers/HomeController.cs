using CarRentalApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentalApp.Entity;


namespace Car_Rental_MVC.Controllers
{
    public class HomeController : Controller
    {
        private CarBrandBusiness _carBrandBusiness;
        private CarBusiness _carBusiness;
        private CustomerBusiness _customerBusiness;
        private ReservationBusiness _reservationBusiness;
        public HomeController()
        {
            _carBrandBusiness = new CarBrandBusiness();
            _carBusiness = new CarBusiness();
            _customerBusiness = new CustomerBusiness();
            _reservationBusiness = new ReservationBusiness();

        }
        public ActionResult Index()
        {
            ViewBag.Car = _carBusiness.GetAll();
            ViewBag.Car = _carBrandBusiness.GetAll();
            return View();
        }
    }
}