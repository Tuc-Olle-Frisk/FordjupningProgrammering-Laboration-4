using Northwind.EntityModels;

namespace Northwind.Mvc.Models
{
    public class CategoryModel
    {
        public Category? SelectedCategory { get; set; }
        public IList<Product>? Products;
    }
}
