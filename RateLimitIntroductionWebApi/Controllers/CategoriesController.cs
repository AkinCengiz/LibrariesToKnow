using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimitIntroductionWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
	[HttpGet]
	public IActionResult GetCategory()
	{
		return Ok(new { Id = 1, CategoryName = "Kırtasiye" });
	}
}
