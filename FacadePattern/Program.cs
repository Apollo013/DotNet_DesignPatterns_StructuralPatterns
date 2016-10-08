using FacadePattern.Facades;
using FacadePattern.Models;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();
            Customer cust = new Customer("Howya Mary");
            var result = (mortgage.IsEligible(cust, 12500)) ? "Approved" : "Rejected";
            System.Console.WriteLine($"Loan for {cust.Name} has been {result}");
        }
    }
}
