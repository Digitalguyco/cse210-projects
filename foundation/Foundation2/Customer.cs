using System;
using System.Collections.Generic;

class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer is in the USA (delegates to Address)
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the shipping label information
    public string GetShippingLabel()
    {
        return $"{name}\n{address.GetFullAddress()}";
    }
}