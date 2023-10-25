using Abstractions;
using System.ComponentModel;

namespace Repository.Repositories;

public class MockedCustomerRepository : ICustomerRepository
{
    private List<ICustomer> _customersInDatabase = new List<ICustomer>();

    public bool DeleteCustomer(int id)
    {
        var customer = _customersInDatabase.FirstOrDefault(x => x.Id == id);
        if (customer == null)
            return false;

        _customersInDatabase.Remove(customer);
        return true;
    }

    public IEnumerable<ICustomer> GetAllCustomers()
    {
        return _customersInDatabase.AsEnumerable();
    }

    public ICustomer GetCustomerById(int id)
    {
        return _customersInDatabase.First(x => x.Id == id);
    }

    public bool CreateCustomer(ICustomer customer)
    {
        customer.Id = GenerateId();
        _customersInDatabase.Add(customer);
        return true;
    }

    public bool UpdateCustomer(ICustomer customer)
    {
        var cupdate = GetCustomerById(customer.Id);
        cupdate.FirstName = customer.FirstName;
        cupdate.LastName = customer.LastName;
        cupdate.Email = customer.Email;
        cupdate.Phonenumber = customer.Phonenumber;
        return true;
    }

    public bool WriteToDatabase(ICustomer customer)
    {
        if (customer == null)
        {
            return false;
        }

        if (customer.Id == default)
        {
            // Create
            return CreateCustomer(customer);
        }
        else
        {
            // Update
            return UpdateCustomer(customer);
        }
    }

    private int GenerateId()
    {
        if (!_customersInDatabase.Any())
        {
            return 1;
        }

        int highestId = _customersInDatabase.Max(x => x.Id);
        return ++highestId;
    }
}