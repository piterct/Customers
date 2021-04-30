using Customers.Domain.Entities;
using System.Collections.Generic;

namespace Customers.Domain.Queries
{
    public class CustomerQuery
    {
        public List<CustomerEntity> Clientes { get; set; }
    }
}
