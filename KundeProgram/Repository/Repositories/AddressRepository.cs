using Abstractions;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories;

public class AddressRepository : IAddressRepository
{
    public bool CreateAddress(IAddress addr)
    {
        using (CustomerContext context = new CustomerContext())
        {
            Models.Address address = new Models.Address(addr);
            context.Addresses.Add(address);

            bool rtn = context.SaveChanges() > 0;
            if (rtn) 
                addr.Id = address.Id;

            return rtn;
        }
    }

    public bool UpdateAddress(IAddress addr)
    {
        using (CustomerContext context = new CustomerContext())
        {
            Models.Address address = new Models.Address(addr);
            context.Addresses.Update(address);

            bool rtn = context.SaveChanges() > 0;
            if (rtn)
                addr.Id = address.Id;

            return rtn;
        }
    }

    public bool DeleteAddress(IAddress addr)
    {
        using (CustomerContext context = new CustomerContext())
        {
            Models.Address? address = GetAddressById(addr.Id) as Models.Address;
            if (address != null)
            {
                context.Addresses.Remove(address);
                return context.SaveChanges() > 0;
            }

            return false;
        }
    }

    public IAddress? GetAddressById(int id)
    {
        using (CustomerContext context = new CustomerContext())
        {
            return context.Addresses.FirstOrDefault(x => x.Id == id);
        }
    }

    public IEnumerable<IAddress> GetAllAddresses()
    {
        using (CustomerContext context = new CustomerContext())
        {
            return context.Addresses;
        }
    }

}
