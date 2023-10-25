using Abstractions;
using Service.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace KundeProgramUI;

public partial class Form1 : Form
{
    private readonly ICustomerService _customerService;
    private readonly IAddressService _addressService;

    // Binding list will automatically update out listbox on changes
    public BindingList<ICustomer> Customers { get; set; }

    public Form1(ICustomerService customerService, IAddressService addressService)
    {
        InitializeComponent();
        _customerService = customerService;
        _addressService = addressService;
        Customers = new BindingList<ICustomer>(customerService.GetAllCustomers().ToList());
        lb_customers.DataSource = Customers;
        lb_customers.DisplayMember = "Name";
    }

    private void btn_OpenCustomerRegistration_Click(object sender, EventArgs e)
    {
        Forms.RegisterCustomerForm registerCustomerForm = new Forms.RegisterCustomerForm(_customerService, _addressService);
        registerCustomerForm.CustomerRegistered += RegisterCustomerForm_CustomerRegistered;
        registerCustomerForm.ShowDialog();
        registerCustomerForm.CustomerRegistered -= RegisterCustomerForm_CustomerRegistered;
    }

    private void RegisterCustomerForm_CustomerRegistered(object? sender, ICustomer e)
    {
        Customers.Add(e);
    }

    private void btn_DeleteCustomer_Click(object sender, EventArgs e)
    {
        if (lb_customers.SelectedItem is ICustomer customer)
        {
            if (MessageBox.Show($"Are you sure you will delete the customer {customer.FirstName} {customer.LastName}", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (_customerService.DeleteCustomer(customer.Id))
                    Customers.Remove(customer);
            }
        }
    }

    private void btn_UpdateCustomer_Click(object sender, EventArgs e)
    {
        if (lb_customers.SelectedItem is ICustomer customer)
        {
            Forms.UpdateCustomerForm updateCustomerForm = new Forms.UpdateCustomerForm(_customerService, _addressService, customer);
            updateCustomerForm.CustomerUpdated += UpdateCustomerForm_CustomerUpdated;
            updateCustomerForm.ShowDialog();
            updateCustomerForm.CustomerUpdated -= UpdateCustomerForm_CustomerUpdated;
        }

    }

    private void UpdateCustomerForm_CustomerUpdated(object? sender, ICustomer e)
    {
        for (int i = 0; i < Customers.Count; i++)
        {
            if (Customers[i].Id == e.Id)
            {
                Customers[i] = e;
                break;
            }
        }
    }
}