using System;
using System.Collections.Generic;
class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double total = 0;

        // Calculate total product costs
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        if (customer.IsInUSA())
        {
            total += 5;  // Shipping cost for USA
        }
        else
        {
            total += 35;  // Shipping cost for outside USA
        }

        return total;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"- {product.GetPackingLabel()}\n";
        }
        return packingLabel;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetShippingLabel()}";
    }
}