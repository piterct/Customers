using System;
using System.Threading.Tasks;

namespace Customers.Domain.Entities
{
    public class Customer
    {
        public Customer(int id, string name, string cpf, decimal salary)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Salary = salary;

        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public decimal Salary { get; private set; }

        public async void SalaryCustomerCalculation()
        {
            await Task.FromResult(this.Salary = Math.Round(this.Salary * 0.30M, 2));
        }
    }
}
