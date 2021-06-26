using System.Collections.Generic;
using System.Linq;
using FirstSite.Data.Interfaces;
using FirstSite.Data.Models;

namespace FirstSite.Data.Mocks
{
    public class MockCars: IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Nissan Qashqai", 
                        shortDesc = "Кроссовер", 
                        longDesc = "Идеальный автомбиль для города и не только", 
                        img = "/img/qashqai.jpg", 
                        price = 450, 
                        isFavourite = true,
                        available = true, 
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford F-150 Raptor", 
                        shortDesc = "Пикап", 
                        longDesc = "Самый крутой и злой пикап на земле", 
                        img = "/img/Raptor.jpg", 
                        price = 500, 
                        isFavourite = true,
                        available = true, 
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Subaru Forester", 
                        shortDesc = "Кроссовер", 
                        longDesc = "Спортивный кроссовер", 
                        img = "/img/fondrik.jpg", 
                        price = 500, 
                        isFavourite = false,
                        available = true, 
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Tesla S Plaid", 
                        shortDesc = "Электромобиль", 
                        longDesc = "1,9 секунды до 100", 
                        img = "/img/tesla.jpg", 
                        price = 500, 
                        isFavourite = true,
                        available = true, 
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf", 
                        shortDesc = "Электромобиль", 
                        longDesc = "Гавно", 
                        img = "/img/kaka.jpg", 
                        price = 500, 
                        isFavourite = false,
                        available = true, 
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf", 
                        shortDesc = "Электромобиль", 
                        longDesc = "Гавно", 
                        img = "/img/kaka.jpg", 
                        price = 500, 
                        isFavourite = false,
                        available = true, 
                        Category = _carsCategory.AllCategories.Last()
                    }
                };
            }
      
        }
        
        public IEnumerable<Car> getFavCars { get; set; }
        public Car getObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}