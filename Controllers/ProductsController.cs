using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = new List<Product>
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
        return Ok(products);
    }
}