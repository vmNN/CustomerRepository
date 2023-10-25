using Abstractions;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeProgramUI.Forms
{
    public partial class UpdateCustomerForm : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAddressService _addressService;
        private readonly ICustomer _customer;
        public event EventHandler<ICustomer>? CustomerUpdated;

        private string _emailBackup;
        private string _firstnameBackup;
        private string _lastnameBackup;
        private string _phoneNoBackup;


        private string _streetBackup;
        private string _houseNoBackup;
        private string _zipBackup;
        private string _cityBackup;






        public UpdateCustomerForm(ICustomerService customerService, IAddressService addressService, ICustomer customer)
        {
            InitializeComponent();
            _customerService = customerService;
            _addressService = addressService;
            _customer = customer;

            txb_firstname.Text = _firstnameBackup = _customer.FirstName;
            txb_lastname.Text = _lastnameBackup = _customer.LastName;
            txb_phoneNo.Text = _phoneNoBackup = _customer.Phonenumber;
            txb_email.Text =  _emailBackup = _customer.Email;

            if (_customer.Address != null)
            {
                btn_DeleteAddress.Visible = true;

                txb_streetname.Text = _streetBackup = _customer.Address.StreetName;
                txb_housenumber.Text = _houseNoBackup = _customer.Address.HouseNumber;
                txb_zip.Text = _zipBackup = _customer.Address.Zipcode;
                txb_City.Text = _cityBackup = _customer.Address.City;
            }
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {

            if (_firstnameBackup != txb_firstname.Text || _lastnameBackup != txb_lastname.Text
                || _phoneNoBackup != txb_phoneNo.Text || _emailBackup != txb_email.Text)
            {
                if (!_customerService.UpdateCustomer(_customer.Id, txb_firstname.Text, txb_lastname.Text, txb_phoneNo.Text, txb_email.Text, out ICustomer customer))
                {
                    MessageBox.Show("There was a problem updating the user!", "Problem!", MessageBoxButtons.OK);
                    return;
                }
            }

            if (_streetBackup != txb_streetname.Text || _houseNoBackup != txb_housenumber.Text
                || _zipBackup != txb_zip.Text || _cityBackup != txb_City.Text)
            {
                if (_customer.Address == null)
                {
                    // Create
                    if (_addressService.CreateAddress(txb_streetname.Text, txb_housenumber.Text, txb_City.Text, txb_zip.Text, out IAddress address))
                    {
                        _customerService.AddAddressToCustomer(_customer.Id, address.Id);
                        _customer.Address = address;
                    }
                    else
                    {
                        MessageBox.Show("There was an error creating the address!", "Problem!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // Update
                    if (_addressService.UpdateAddress(_customer.Address.Id, txb_streetname.Text, txb_housenumber.Text, txb_City.Text, txb_zip.Text, out IAddress address))
                    {
                        _customer.Address = address;
                    }
                    else
                    {
                        MessageBox.Show("There was an error updating the address!", "Problem!", MessageBoxButtons.OK);
                    }
                }
            }

            CustomerUpdated?.Invoke(this, _customer);
            this.Close();
        }

        private void btn_DeleteAddress_Click(object sender, EventArgs e)
        {
            if (_customerService.RemoveAddressFromCustomer(_customer.Id, _customer.Address!.Id))
            {
                btn_DeleteAddress.Visible = false;

                txb_streetname.Text = _streetBackup = "";
                txb_housenumber.Text = _houseNoBackup = "";
                txb_zip.Text = _zipBackup = "";
                txb_City.Text = _cityBackup = "";

                _customer.Address = null;

                CustomerUpdated?.Invoke(this, _customer);
            }
            else
            {
                MessageBox.Show("Failed to delete the relationship between customer and address!", "Problem!", MessageBoxButtons.OK);
            }
        }
    }
}
