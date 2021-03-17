namespace Customers.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }
    }
}
