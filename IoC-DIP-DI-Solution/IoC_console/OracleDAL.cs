namespace IoC_console
{
    class OracleDAL : DataAccessLayerInterface
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Oracle Laptop", Price = 999.99m, Stock = 10 },
                new Product { Id = 2, Name = "Oracle Smartphone", Price = 499.99m, Stock = 25 },
                new Product { Id = 3, Name = "Oracle Tablet", Price = 299.99m, Stock = 15 }
            };
        }
    }
}
