using Abstractions;

namespace Repository.Models;

public class Address : IAddress
{
    public int Id { get; set; }
    public string Zipcode { get; set; }
    public string StreetName { get; set; }
    public string HouseNumber { get; set; }
    public string City { get; set; }


    public Address(IAddress? address)
    {
        this.Id = address.Id;
        this.Zipcode = address.Zipcode;
        this.StreetName = address.StreetName;
        this.HouseNumber = address.HouseNumber;
        this.City = address.City;
    }

    public Address()
    {
        
    }
}