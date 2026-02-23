using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

public class IndexModel: PageModel
{
    public List<Product> Products {get; set;} = new();

    public void OnGet()
    {
        Products = new List<Product>
      {
            new Product { Id = 1, Name = "Laptop", Price = 999.9},
            new Product { Id = 2, Name = "Mouse", Price = 999.9},
            new Product { Id = 3, Name = "Smartphone", Price = 999.9}
        };
    }
}