using System;

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
    class Program
    {
        static void Main(string[] args)
        {
            

            PayService payService = new PayService();

            payService.PayEmployees();
            
        }

        
    }
}
