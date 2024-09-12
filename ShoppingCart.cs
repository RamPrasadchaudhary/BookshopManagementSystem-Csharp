using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq; // Add this line for LINQ methods

public class ShoppingCart
{
    private List<Product> _cartItems;

    public ShoppingCart()
    {
        _cartItems = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        _cartItems.Add(product);
    }

    public void RemoveFromCart(int productId)
    {
        _cartItems.RemoveAll(p => p.ID == productId);
    }

    public decimal CalculateTotal()
    {
        // Ensure that the _cartItems list is not null
        if(_cartItems == null || !_cartItems.Any())
            return 0;

        // Calculate the total using the Sum method
        return _cartItems.Sum(p => p.Price * p.Quantity);
    }
    public List<Product> GetCartItems()
    {
        return _cartItems;
    }

    public void ClearCart()
    {
        _cartItems.Clear();
    }

    public void DisplayCartItems()
    {
        foreach(var item in _cartItems)
        {
            Console.WriteLine(item);
        }
    }
}
