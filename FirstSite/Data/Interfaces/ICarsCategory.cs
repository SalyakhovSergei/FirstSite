using System.Collections.Generic;
using FirstSite.Data.Models;

namespace FirstSite.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}