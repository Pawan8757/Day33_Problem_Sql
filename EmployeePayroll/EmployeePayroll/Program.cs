using System;
namespace EmployeePayroll
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Pawan Kumar";
            employee.PhoneNumber = "9304314938";
            employee.Address = "Rafiganj";
            employee.Department = "Hr";
            employee.Gender = 'M';
            employee.BasicPay = 22000;
            employee.Deduction = 1500;
            employee.TaxablePay = 200;
            employee.Tax = 300;
            employee.NetPay = 2500;
            employee.City = "Aurangabad";
            employee.Country = "India";

            repo.AddEmployee(employee);
        }
    }
}