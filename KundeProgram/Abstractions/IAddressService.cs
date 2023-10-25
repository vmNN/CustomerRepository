using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions;

public interface IAddressService
{
    bool CreateAddress(string streetName, string houseNumber, string City, string zipCode, out IAddress address);

    bool UpdateAddress(int id, string streetName, string houseNumber, string City, string zipCode, out IAddress address);

    bool DeleteAddress(int id);
    IAddress? GetAddressById(int id);

    IEnumerable<IAddress> GetAllAddresses();
}
