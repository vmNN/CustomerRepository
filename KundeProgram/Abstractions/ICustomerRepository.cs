namespace Abstractions;

public interface ICustomerRepository
{ 
    bool CreateCustomer(ICustomer customer);
    bool UpdateCustomer(ICustomer customer);

    bool DeleteCustomer(int id);

    ICustomer GetCustomerById(int id);

    IEnumerable<ICustomer> GetAllCustomers();
}