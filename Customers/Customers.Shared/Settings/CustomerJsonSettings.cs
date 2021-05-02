using System.Collections.Generic;

namespace Customers.Shared.Settings
{
    public class CustomerJsonSettings
    {
        public List<ClientesJson> ClientesJson { get; set; }
    }

    public class ClientesJson
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }
    }
}
