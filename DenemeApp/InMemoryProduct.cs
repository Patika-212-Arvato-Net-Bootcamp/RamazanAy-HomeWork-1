namespace DenemeApp;

public class InMemoryProduct
{
     public List<Product> _products = new List<Product>();

     public InMemoryProduct()
     {
         _products.Add(new Product("Iphone 12"));
         _products.Add(new Product("Ipad"));
         _products.Add(new Product("MacBook"));
         _products.Add(new Product("Airpods"));
         
     }
}