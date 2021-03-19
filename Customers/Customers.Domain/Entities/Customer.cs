using System;
using System.Threading.Tasks;

namespace Customers.Domain.Entities
{
    public class Customer
    {
        public Customer(int id, string nome, string cpf, decimal salario)
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

        public async void SalaryCustomerCalculation()
        {
            await Task.FromResult(this.Salario = Math.Round(this.Salario * 0.30M, 2));
        }
    }
}
