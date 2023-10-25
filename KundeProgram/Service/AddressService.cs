using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public bool CreateAddress(string streetName, string houseNumber, string city, string zipCode, out IAddress address)
    {
        address = new Models.Address()
        {
            StreetName = streetName,
            HouseNumber = houseNumber,
            City = city,
            Zipcode = zipCode
        };

        return _addressRepository.CreateAddress(address);
    }

    public bool UpdateAddress(int id, string streetName, string houseNumber, string city, string zipCode, out IAddress address)
    {
        address = new Models.Address()
        {
            Id = id,
            StreetName = streetName,
            HouseNumber = houseNumber,
            City = city,
            Zipcode = zipCode
        };

        return _addressRepository.UpdateAddress(address);
    }

    public bool DeleteAddress(int id)
    {
        var adddress = GetAddressById(id);
        return _addressRepository.DeleteAddress(adddress);
    }

    public IAddress? GetAddressById(int id)
    {
        return _addressRepository.GetAddressById(id);
    }

    public IEnumerable<IAddress> GetAllAddresses()
    {
        return _addressRepository.GetAllAddresses();
    }
}
