namespace Abstractions;

public interface ICustomer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phonenumber { get; set; }

    public string Email { get; set; }

    public IAddress? Address { get; set; }

    public string Name { get; }
}