using System;


namespace StrategyPatternExample

{
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

    public abstract class PayCalculator
    {
        internal abstract int CalculatePay(int grossPay);
      
    }
    internal class SalariedCalculator : PayCalculator
    {
        internal override int CalculatePay(int grossPay)
        {
            return grossPay - (int)(grossPay * .2);
        }
    }
    internal class HourlyCalculator : PayCalculator
    {
        internal override int CalculatePay(int grossPay)
        {
            var fullPay = (int)(grossPay * 40 * 52);
            return fullPay -  (int)(fullPay * .15);
        }
    }
}