using Abstractions;

namespace Service.Models;

public class Address : IAddress
{
    public int Id { get; set; }
    public string Zipcode { get; set; }
    public string StreetName { get; set; }
    public string HouseNumber { get; set; }
    public string City { get; set; }

}