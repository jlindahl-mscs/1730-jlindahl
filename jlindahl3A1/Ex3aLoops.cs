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
                while (1 <= months)
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
                while (1 <= months);
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
            string result = "";

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

    }
}
