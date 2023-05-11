class Product
{
    public string Code;
    public string Description;
    public Decimal Price;

    public Product (string c, string d, decimal p);
    {
        Code = c;
        Description = d;
        Price = p;
    }


}

    
class Program
{
        private static void Main(string[] arg)
        {

            static void SaveProducts (List<Product)
            {
                
            }


            static void Main(string[] arg)
            List<Product> products = new List<Product>();
            products.Add(new Produc ("AAA", "Lapiz", 23.52m));
            ProductsDB.SaveProducts(products);
        }
    }

    class ProductsDB
{
    public static void SaveProducts(List<Product> products)
}