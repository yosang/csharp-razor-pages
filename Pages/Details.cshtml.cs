using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

public class Details:PageModel
{
    public Product? Product {get; set;}
    public int Id {get; set;}

    private readonly List<Product> _products = new()
    {
            new Product { Id = 1, Name = "Laptop", Price = 999.9},
            new Product { Id = 2, Name = "Mouse", Price = 999.9},
            new Product { Id = 3, Name = "Smartphone", Price = 999.9}
        };
    public void OnGet(int id)
    {
        Id = id;
        Product = _products.Find((i) => i.Id == id);
    }

}