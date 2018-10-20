namespace Ex141
{
    /// <summary>
    /// API получения адреса
    /// </summary>
    static class ApiGetAddress
    {
        /// <summary>
        /// Метод получения адреса
        /// </summary>
        /// <returns></returns>
        static public Address Get()
        {
            //return new Address() { city = new City() { street = new Street() { house = new House() { N = 221 } } } };
            return new Address() { };
        }
    }
}
