using Abstractions;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public bool DeleteCustomer(int id)
    {
        using (CustomerContext context = new CustomerContext())
        {
            var customer = context.Customers.Include(x => x.AddressConcrete).FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                if (customer.Address != null)
                    context.Addresses.Remove(customer.AddressConcrete);

                context.Customers.Remove(customer);
                if (context.SaveChanges() > 0)
                    return true;
            }
        }
        return false;
    }

    public IEnumerable<ICustomer> GetAllCustomers()
    {
        using (CustomerContext context = new CustomerContext())
        {
            return context.Customers.Include(x => x.AddressConcrete).ToList<ICustomer>();
        }
    }

    public ICustomer GetCustomerById(int id)
    {
        using (CustomerContext context = new CustomerContext())
        {
            var customer = context.Customers.Include(x => x.AddressConcrete).First(x => x.Id == id);
            return customer;
        }
    }

    public bool CreateCustomer(ICustomer customer)
    {
        Models.Customer concreteCustomer = new Models.Customer
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Phonenumber = customer.Phonenumber,
            Email = customer.Email,
            Address = customer.Address
        };

        using (CustomerContext context = new CustomerContext())
        {
            context.Customers.Add(concreteCustomer);
            return context.SaveChanges() > 0;
        }
    }

    public bool UpdateCustomer(ICustomer customer)
    {
        using (CustomerContext context = new CustomerContext())
        {
            Models.Customer? concreteCustomer = context.Customers.Include(x => x.AddressConcrete).FirstOrDefault(x => x.Id == customer.Id);
            if (concreteCustomer == null)
                return false;

            concreteCustomer.FirstName = customer.FirstName;
            concreteCustomer.LastName = customer.LastName;
            concreteCustomer.Phonenumber = customer.Phonenumber;
            concreteCustomer.Email = customer.Email;
            concreteCustomer.Address = customer.Address;

            int rowAffected = context.SaveChanges();

            if (rowAffected > 0)
            {
                return true;
            }


            return false;
        }
    }

}
