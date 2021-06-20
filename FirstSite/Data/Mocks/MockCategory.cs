using System.Collections.Generic;
using FirstSite.Data.Interfaces;
using FirstSite.Data.Models;

namespace FirstSite.Data.Mocks
{
    public class MockCategory: ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category("Electric", "modern vehicles"),
                    new Category("Gasoline", "true motors"),
                };
            }
        }
    }
}