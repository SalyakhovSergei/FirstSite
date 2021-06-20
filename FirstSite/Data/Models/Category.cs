using System.Collections.Generic;

namespace FirstSite.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Car> cars { get; set; }

        public Category(string categoryName, string desc)
        {
            this.categoryName = categoryName;
            this.desc = desc;
        }
    }
    
}