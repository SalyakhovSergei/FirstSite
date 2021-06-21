using FirstSite.Data.Interfaces;
using FirstSite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstSite.Controllers
{
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allcategories;

        public CarsController(IAllCars allCars, ICarsCategory allcategories)
        {
            _allCars = allCars;
            _allcategories = allcategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page cars";

            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.carCategory = "drachki";
                       
            return View(obj);
        }
    }
}