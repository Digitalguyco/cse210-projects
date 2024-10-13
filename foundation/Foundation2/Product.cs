using System;
using System.Collections.Generic;


class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to get total cost for this product
    public double GetTotalCost()
    {
        return price * quantity;
    }

    // Method to get packing label information
    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId})";
    }
}