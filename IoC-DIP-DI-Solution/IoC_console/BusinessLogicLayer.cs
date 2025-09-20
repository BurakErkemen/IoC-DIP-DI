namespace IoC_console
{
    class BusinessLogicLayer 
    {

        private DataAccessLayerInterface _dataAccessLayer;
        public BusinessLogicLayer()
        {
            _dataAccessLayer = DataAccessLayerFactory.GetDAL();
        }
        public List<Product> ProcessData()
        {
            return _dataAccessLayer.GetProducts();
        }

    }
}
