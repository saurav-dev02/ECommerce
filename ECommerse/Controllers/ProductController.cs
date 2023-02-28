using ECommerse.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerse.Controllers
{
	//hostname/api/product
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpGet("")]
		public ActionResult GetProducts(string searchTerm)
		{
			return Ok();
		}

		//[HttpGet("/all")]
		//public ActionResult GetProductByName(string searchTerm)
		//{
		//	return Ok();
		//}

		[HttpGet("{id}")]
		public ActionResult GetProduct(int id)
		{
			return Ok();
		}

		[HttpPost]
		public ActionResult CreateProduct(Product productToCreate)
		{
			return Ok();
		}

		[HttpPut("{id}")]
		public ActionResult UpdateProduct(int id, Product prodcutToUpdate)
		{
			return Ok();
		}

		[HttpDelete("{id}")]
		public ActionResult DeleteProduct(int id)
		{
			return Ok();
		}


	}
}
