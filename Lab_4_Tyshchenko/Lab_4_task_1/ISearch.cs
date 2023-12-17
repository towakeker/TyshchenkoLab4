using System.Collections.Generic;

namespace Lab_4_task_1
{
    public interface ISearch
    {
        List<Product> SearchByPriceRange(double minPrice, double maxPrice);
        List<Product> SearchByCategory(string category);
    }
}