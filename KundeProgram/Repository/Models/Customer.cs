using Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models;

public class Customer : ICustomer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phonenumber { get; set; }

    public string Email { get; set; }

    [NotMapped]
    public IAddress? Address
    {
        get => AddressConcrete; 
        set => AddressConcrete = value != null ? new Address(value) : null;
    }

    public Address? AddressConcrete { get; set; }
    public string Name => string.Join(" ", FirstName, LastName);
}