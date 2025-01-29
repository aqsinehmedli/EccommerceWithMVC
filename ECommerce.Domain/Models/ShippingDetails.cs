using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Models;

public class ShippingDetails
{
	//[Required] -  //Eger istifadeci bu hisseni bos qoyarsa xeta verecek.Null olmasinin qarsisini almaq ucun istifade edilir.
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	[DataType(DataType.EmailAddress)]
	public required string Email { get; set; }
	public required string Address { get; set; }
	public required string City { get; set; }
	[Range(15,75)]
	public required string Age { get; set; }
}
