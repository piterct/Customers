using System.Collections.Generic;

namespace Customers.Shared.Settings
{
    public class CustomerJsonSettings
    {
        public List<Clientes> ClientesJson { get; set; }
    }

    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }
    }
}
