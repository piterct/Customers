using System.Collections.Generic;

namespace Customers.Shared.Settings
{
    public class CustomerJsonSettings
    {
        public List<CustomersJson> CustomersJson { get; set; }
    }

    public class CustomersJson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public decimal Salary { get; set; }
    }
}
