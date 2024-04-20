using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimitIntroductionWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
	[HttpGet]
	public IActionResult GetProduct()
	{
		return Ok(new { Id = 1, Name = "Kalem", Price = 20 });
	}

	[HttpPost]
	public IActionResult CreateProduct(string name, decimal price)
	{
		var p = new { Name = name, Price = price };
		return Ok($"Product added success...\n{p.Name} - {p.Price}");
	}
}
