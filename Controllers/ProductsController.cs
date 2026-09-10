using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id=1,
                Name="Laptop",
                Price=75000
            },
            new Product
            {
                Id=2,
                Name="Mouse",
                Price=1500
            }
        };

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(products);
    }

    [HttpPost]
    public IActionResult AddProducts(Product product)
    {
        products.Add(product);
        return Ok(products);
    }
}