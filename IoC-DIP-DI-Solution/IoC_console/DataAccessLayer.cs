namespace IoC_console
{
    class DataAccessLayer : DataAccessLayerInterface
    {

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, Stock = 10 },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Stock = 25 },
                new Product { Id = 3, Name = "Tablet", Price = 299.99m, Stock = 15 }
            };
        }

        public int Hesaplama()
        {
            return 100;
        }
    }
}
