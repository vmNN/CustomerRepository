using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions;

public interface IAddressRepository
{
    bool CreateAddress(IAddress addr);

    bool UpdateAddress(IAddress addr);

    bool DeleteAddress(IAddress addr);
    IAddress? GetAddressById(int id);

    IEnumerable<IAddress> GetAllAddresses();
}
