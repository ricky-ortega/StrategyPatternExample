using System.Collections.Generic;

/// <summary>
/// Employees have a current pay (Gross Pay)
/// 
/// Two different employees
/// --- Salary 
/// ------ 20 % tax 
/// --- Hourly 
/// ------ 15% tax
/// 
/// Calculating pay for Salary 
/// Calculating pay for Hourly
/// 
/// </summary>

namespace StrategyPatternExample
{
    internal class PayService
    {
        private List<Employee> employees = new List<Employee>
            {
                new Employee { Salaried = true, GrossPay = 50000 },
                new Employee { Salaried = true, GrossPay = 60000 },
                new Employee { Salaried = true, GrossPay = 70000 },
                new Employee { Salaried = false, GrossPay = 40 },
                new Employee { Salaried = true, GrossPay = 30000 },
                new Employee { Salaried = false, GrossPay = 90 },
                new Employee { Salaried = true, GrossPay = 40000 },
                new Employee { Salaried = true, GrossPay = 30000 },
                new Employee { Salaried = false, GrossPay = 20 },
                new Employee { Salaried = true, GrossPay = 80000 },
                new Employee { Salaried = false, GrossPay = 60 },
            };

     

        internal List<Employee> PayEmployees()
        {
            foreach (var employee in employees)
            {
                if (employee.Salaried)
                {
                    employee.NetPay = new SalariedCalculator().CalculatePay(employee.GrossPay);
                }
                else
                {
                    employee.NetPay = new HourlyCalculator().CalculatePay(employee.GrossPay);
                }
            }

            return employees;
        }
    }
}
