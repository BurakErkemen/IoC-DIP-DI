namespace IoC_console
{
    class BusinessLogicLayer 
    {

        private DataAccessLayerInterface _dataAccessLayer;
        public BusinessLogicLayer(DataAccessLayerInterface dataAccessLayerInterface)
        {
            //_dataAccessLayer = DataAccessLayerFactory.GetDAL();
            _dataAccessLayer = dataAccessLayerInterface;
        }


        public List<Product> ProcessData()
        {
            return _dataAccessLayer.GetProducts();
        }

    }
}
