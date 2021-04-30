namespace Customers.Domain.Commands.Output
{
    public class GetCustomerByCPFCommandOutput
    {
        public GetCustomerByCPFCommandOutput(int id, string nome, string cpf, decimal salario)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public decimal Salario { get; private set; }
    }
}
