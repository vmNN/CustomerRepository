namespace Abstractions;

public interface IAddress
{
    int Id { get; set; }
    string Zipcode { get; set; }
    string StreetName { get; set; }
    string HouseNumber { get; set; }
    string City { get; set; }
}