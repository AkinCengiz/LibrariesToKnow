namespace FluentValidationApp.MVC.Models;

public class Address
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Town { get; set; }
    public string District { get; set; }
    public string Street { get; set; }
    public byte BuildNumber { get; set; }
    public string ZipCode { get; set; }
    public virtual Customer Customer { get; set; }
}
