namespace IoC_console
{
    class DataAccessLayerFactory
    {
        public static DataAccessLayerInterface GetDAL() { return new DataAccessLayer(); }
    }
}
