using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jlindahl3A1
{
   public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1;
        //    int sum = 0;
        //    while (i < 3)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }
            
            return futureValue.ToString("n2");
        }
        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }
        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                }
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
            }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            //Count, do
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                int end = Int32.Parse(strEnd);
                int start = Int32.Parse(strStart);
                int i = start;
                if (increment <= 0) throw new Exception();
                while (i <= end)
                {
                    result = result + start + (1 * increment);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                int end = Int32.Parse(strEnd);
                int start = Int32.Parse(strStart);
                int i = 1;
                if (increment <= 0) throw new Exception();
                do
                {
                    result = result += start += increment;
                    i++;
                }
                while (i <= end);
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                int end = Int32.Parse(strEnd);
                int start = Int32.Parse(strStart);
                int i = 1;
                if (increment <= 0) throw new Exception();
                if (start >= end) throw new Exception();
                for (i = 1; i < start;)
                {
                    result = result += start * increment;
                }
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            try
            {
                int count = Int32.Parse(strCount);
                
                while (count <= startIndex)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);

                    startIndex = endIndex + 1;

                    count += number;
                    count++;
                }

            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            try
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                int number = Int32.Parse(strNumber);

                startIndex = endIndex + 1;
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            try
            {

            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

    }
}
