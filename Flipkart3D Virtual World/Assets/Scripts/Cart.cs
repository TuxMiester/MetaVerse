using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart:MonoBehaviour
{
    private static Cart obj = new Cart();
    public static Cart getobj()
    {
        return obj;
    }
    private static List<string> items = new List<string>();
     protected static void AddtoCart(string item)
    {
        Debug.Log("Successfully Added to Cart!");
        items.Add(item);
    }
    protected static void RemoveFromCart(string item)
    {
        items.Remove(item);
    }
    protected void Checkout()
    {
        Debug.Log("Going to Flipkart Website.......");
    }
}
