using System.Text.Json.Serialization;

namespace Customers.Domain.Commands.Output
{
    public class GetCustomerByIdCommandOutPut
    {
        public GetCustomerByIdCommandOutPut(int id, string nome, string cpf, decimal salario)
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

