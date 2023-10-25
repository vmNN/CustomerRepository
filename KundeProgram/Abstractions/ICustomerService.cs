namespace Abstractions;

public interface ICustomerService
{
    bool CreateCustomer(string firstname, string lastname, string phoneNo, string email, out ICustomer customer);
    bool UpdateCustomer(int id, string firstname, string lastname, string phoneNo, string email, out ICustomer customer);
    bool DeleteCustomer(int id);

    ICustomer GetCustomerById(int id);

    IEnumerable<ICustomer> GetAllCustomers();

    bool AddAddressToCustomer(int customerId, int addressId);
    bool RemoveAddressFromCustomer(int customerId, int addressId);

}