using Abstractions;
using Service.Models;

namespace Service;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _repository;
    private readonly IAddressRepository _addressRepository;

    public CustomerService(ICustomerRepository repository, IAddressRepository addressRepository)
    {
        _repository = repository;
        _addressRepository = addressRepository;
    }

    public bool CreateCustomer(string firstname, string lastname, string phoneNo, string email, out ICustomer customer)
    {
        customer = new Customer()
        {
            FirstName = firstname,
            LastName = lastname,
            Phonenumber = phoneNo,
            Email = email
        };


        return _repository.CreateCustomer(customer);
    }

    public bool DeleteCustomer(int id)
    {
        return _repository.DeleteCustomer(id);
    }

    public IEnumerable<ICustomer> GetAllCustomers()
    {
        return _repository.GetAllCustomers();
    }

    public ICustomer GetCustomerById(int id)
    {
        return _repository.GetCustomerById(id);
    }

    public bool UpdateCustomer(int id, string firstname, string lastname, string phoneNo, string email, out ICustomer customer)
    {
        customer = new Customer
        {
            Id = id,
            FirstName = firstname,
            LastName = lastname,
            Phonenumber = phoneNo,
            Email = email
        };

        return _repository.UpdateCustomer(customer);
    }


    public bool AddAddressToCustomer(int customerId, int addressId)
    {
        IAddress? address = _addressRepository.GetAddressById(addressId);
        if (address == null)
            return false;
        

        ICustomer customer = GetCustomerById(customerId);
        if (customer == null)
            return false;

        customer.Address = address;
        return _repository.UpdateCustomer(customer);
    }

    public bool RemoveAddressFromCustomer(int customerId, int addressId)
    {

        IAddress? address = _addressRepository.GetAddressById(addressId);
        if (address == null)
            return false;



        ICustomer customer = GetCustomerById(customerId);
        if (customer == null)
            return false;



        customer.Address = null;

        if (_repository.UpdateCustomer(customer))
        {
            return _addressRepository.DeleteAddress(address);
        }

        return false;
    }
}