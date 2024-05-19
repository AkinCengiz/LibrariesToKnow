namespace FluentValidationApp.API.Models;

public class Category
{
	public int Id { get; set; }
	public string CategoryName { get; set; }
	public string Description { get; set; }
	public virtual IList<Product> Products { get; set; }
}
