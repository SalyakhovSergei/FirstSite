using System.Collections.Generic;
using FirstSite.Data.Models;

namespace FirstSite.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> getAllCars { get; set; }
        
        public string carCategory { get; set; }
    }
}