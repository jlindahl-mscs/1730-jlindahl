using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730jlindahl3b
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)

        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            //decimal futureValue = 0m; not needed in this instance since it is being referenced already in the CalculateFutureValue method
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        public static double FahrenheitToCelsius (double fahrenHeit)
        {
            //used website rapidtables . com

            double celsius = 0.00;

            celsius = (fahrenHeit - 32) / 1.8;

            return celsius;
        }

        public static double CelsiusToFahrenheit (double celsius, out double fahrenheit)
        {

            fahrenheit = (celsius * 1.8) + 32;

            return fahrenheit;
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
           decimal total = 0m;

            if (hours <= 40)
                total = rate * hours;

            else
                total = (40 * rate) + (hours - 40) * (rate * 1.5m);

            return total;

        }
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;

            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;

            }
            return total;

        }

        public static decimal GrossPayString (string strNumbers, decimal rate)
            
        {
            
            decimal total = 0m;
            decimal strNumber = Decimal.Parse(strNumbers);
            total = (40 * rate) + (strNumber - 40) * (rate * 1.5m);
            return total;

        }
        
    }
}
