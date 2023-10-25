using System.Diagnostics;
using Abstractions;
using Repository.Models;
using Repository.Repositories;

namespace Unit_Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void WriteToDatabase_Create()
    {
        // Assign
        MockedCustomerRepository repository = new MockedCustomerRepository();

        ICustomer customerAnton = new Customer()
        {
            FirstName = "Anton",
            LastName = "Christiansen",
            Email = "Anfonsen@gmail.com",
            Phonenumber = "+45 31 84 95 29"
        };

        ICustomer customerTheis = new Customer()
        {
            FirstName = "Theis",
            LastName = "Heist",
            Email = "THansen@gmail.com",
            Phonenumber = "+45 12 34 56 78"
        };

        ICustomer customerMartin = new Customer()
        {
            FirstName = "Martin",
            LastName = "Unik",
            Email = "MU@gmail.com",
            Phonenumber = "+45 87 65 43 21"
        };

        // Act
        bool antonResponse = repository.WriteToDatabase(customerAnton);
        bool theisResponse = repository.WriteToDatabase(customerTheis);
        bool martinResponse = repository.WriteToDatabase(customerMartin);

        // Assert

        Assert.IsTrue(antonResponse);
        Assert.IsTrue(theisResponse);
        Assert.IsTrue(martinResponse);

        Assert.IsTrue(customerAnton.Id < customerTheis.Id, $"{customerAnton.Id} < {customerTheis.Id}");
        Assert.IsTrue(customerTheis.Id < customerMartin.Id, $"{customerTheis.Id} < {customerMartin.Id}");
    }

    [TestMethod]
    public void WriteToDatabase_Update()
    {
        // Assign
        MockedCustomerRepository repository = new MockedCustomerRepository();

        ICustomer customerAnton = new Customer()
        {
            FirstName = "Anton",
            LastName = "Christiansen",
            Email = "Anfonsen@gmail.com",
            Phonenumber = "+45 31 84 95 29"
        };

        ICustomer customerTheis = new Customer()
        {
            FirstName = "Theis",
            LastName = "Heist",
            Email = "THansen@gmail.com",
            Phonenumber = "+45 12 34 56 78"
        };

        ICustomer customerMartin = new Customer()
        {
            FirstName = "Martin",
            LastName = "Unik",
            Email = "MU@gmail.com",
            Phonenumber = "+45 87 65 43 21"
        };

        repository.WriteToDatabase(customerAnton);
        repository.WriteToDatabase(customerTheis);
        repository.WriteToDatabase(customerMartin);

        // Act
        customerAnton.Email = "NyeEmail@noget.dk";
        repository.WriteToDatabase(customerAnton);

        // Assert
        Assert.AreEqual("NyeEmail@noget.dk", customerAnton.Email);
        Assert.IsTrue(customerAnton.Id < customerTheis.Id, $"{customerAnton.Id} < {customerTheis.Id}");
        Assert.IsTrue(customerTheis.Id < customerMartin.Id, $"{customerTheis.Id} < {customerMartin.Id}");
    }


    [TestMethod]
    public void GetAllCustomers()
    {
        // Assign
        MockedCustomerRepository repository = new MockedCustomerRepository();

        ICustomer customerAnton = new Customer()
        {
            FirstName = "Anton",
            LastName = "Christiansen",
            Email = "Anfonsen@gmail.com",
            Phonenumber = "+45 31 84 95 29"
        };

        ICustomer customerTheis = new Customer()
        {
            FirstName = "Theis",
            LastName = "Heist",
            Email = "THansen@gmail.com",
            Phonenumber = "+45 12 34 56 78"
        };

        ICustomer customerMartin = new Customer()
        {
            FirstName = "Martin",
            LastName = "Unik",
            Email = "MU@gmail.com",
            Phonenumber = "+45 87 65 43 21"
        };

        repository.WriteToDatabase(customerAnton);
        repository.WriteToDatabase(customerTheis);
        repository.WriteToDatabase(customerMartin);

        // Act
        var customers = repository.GetAllCustomers();

        // Assert
        Assert.IsTrue(customers.Any());
        Assert.IsTrue(customers.Contains(customerAnton));
        Assert.IsTrue(customers.Contains(customerTheis));
        Assert.IsTrue(customers.Contains(customerMartin));
    }

    
    [TestMethod]
    public void GetCustomerById()
    {
        // Assign
        MockedCustomerRepository repository = new MockedCustomerRepository();

        ICustomer customerAnton = new Customer()
        {
            FirstName = "Anton",
            LastName = "Christiansen",
            Email = "Anfonsen@gmail.com",
            Phonenumber = "+45 31 84 95 29"
        };

        ICustomer customerTheis = new Customer()
        {
            FirstName = "Theis",
            LastName = "Heist",
            Email = "THansen@gmail.com",
            Phonenumber = "+45 12 34 56 78"
        };

        ICustomer customerMartin = new Customer()
        {
            FirstName = "Martin",
            LastName = "Unik",
            Email = "MU@gmail.com",
            Phonenumber = "+45 87 65 43 21"
        };

        repository.WriteToDatabase(customerAnton);
        repository.WriteToDatabase(customerTheis);
        repository.WriteToDatabase(customerMartin);

        // Act
        var rtn = repository.GetCustomerById(customerAnton.Id);

        // Assert
        Assert.AreEqual(customerAnton.Id, rtn.Id);
    }

    

    [TestMethod]
    public void Delete()
    {
        // Assign
        MockedCustomerRepository repository = new MockedCustomerRepository();

        ICustomer customerAnton = new Customer()
        {
            FirstName = "Anton",
            LastName = "Christiansen",
            Email = "Anfonsen@gmail.com",
            Phonenumber = "+45 31 84 95 29"
        };

        ICustomer customerTheis = new Customer()
        {
            FirstName = "Theis",
            LastName = "Heist",
            Email = "THansen@gmail.com",
            Phonenumber = "+45 12 34 56 78"
        };

        ICustomer customerMartin = new Customer()
        {
            FirstName = "Martin",
            LastName = "Unik",
            Email = "MU@gmail.com",
            Phonenumber = "+45 87 65 43 21"
        };

        repository.WriteToDatabase(customerAnton);
        repository.WriteToDatabase(customerTheis);
        repository.WriteToDatabase(customerMartin);

        // Act
        repository.DeleteCustomer(customerAnton.Id);
        var customers = repository.GetAllCustomers();

        // Assert
        Assert.IsTrue(customers.Any());
        Assert.IsFalse(customers.Contains(customerAnton));
        Assert.IsTrue(customers.Contains(customerTheis));
        Assert.IsTrue(customers.Contains(customerMartin));
    }
}