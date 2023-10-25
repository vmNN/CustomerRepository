using Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeProgramUI.Forms;

public partial class RegisterCustomerForm : Form
{
    private readonly IAddressService _addressService;
    private readonly ICustomerService _customerService;
    public event EventHandler<ICustomer>? CustomerRegistered;

    public RegisterCustomerForm(ICustomerService customerService, IAddressService addressService)
    {
        InitializeComponent();
        _customerService = customerService;
        _addressService = addressService;
    }

    private void btn_CreateCustomer_Click(object sender, EventArgs e)
    {
        if (_customerService.CreateCustomer(txb_firstname.Text, txb_lastname.Text, txb_phoneNo.Text, txb_email.Text, out ICustomer customer))
        {
            if (!string.IsNullOrWhiteSpace(txb_streetname.Text))
            {
                if (_addressService.CreateAddress(txb_streetname.Text, txb_housenumber.Text, txb_zip.Text, txb_City.Text, out IAddress address))
                {
                    if (_customerService.AddAddressToCustomer(customer.Id, address.Id))
                        customer.Address = address;
                }
                else
                {
                    MessageBox.Show("There was a problem creating the the address!", "Problem!", MessageBoxButtons.OK);
                }
            }

            CustomerRegistered?.Invoke(this, customer);
            this.Close();
        }
        else
        {
            MessageBox.Show("There was a problem creating the user!", "Problem!", MessageBoxButtons.OK);
        }
    }
}
