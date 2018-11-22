using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace _1730jlindahl2H1
{
    public class Ex2HCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            DateTime date1;
            DateTime date2;
            string result = "Invalid input";

            try {
                date1 = DateTime.Parse(strDateA);
                date2 = DateTime.Parse(strDateB);
                TimeSpan daysBetween = date1.Subtract(date2);

                int daysSince = daysBetween.Days;
                result = daysSince + " days";
            }

            catch { }

            return result;
        }

        public static string DateCalc10(string strDateA, string srtDateB)
        {
            string result = "Invalid input";
            DateTime date1;
            DateTime date2;
            try
            {
                date1 = DateTime.Parse(strDateA);
                date2 = DateTime.Parse(srtDateB);
                if (date1 == date2)
                {
                    result = "On time";
                }
                else if (date1 > date2)
                {
                    TimeSpan daysPastDue = date1.Subtract(date2);
                    result = daysPastDue.Days + " days past due";
                }
            }
            catch { }


            return result;

        }

        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            s = s.Remove(0, 1);
            result = s.Insert(0, "cr");
            if (s == " ")
                return "Invalid input";
            return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            s = s.Remove(0, 2);
            result = s.Insert(0,"cr");
            return result;
        }
        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            s = s.Substring(2, 4);
            result = s.ToUpper();
            return result;
        }
        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            char pad = '*';
            s = s.PadLeft(9, pad);
            result = pad + s;
            return result;
        }
        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            result = s.Replace("(", "").Replace(") ", "").Replace("-", "");
            return result;
        }
        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            s = s.Replace("(", "").Replace(") ", "").Replace("-", "");
            result = s.Insert(3, ".").Insert(7, ".");
            if (s.Length < 10)
            {
                s = s.Replace("(", ".").Replace(") ", ".").Replace("-", ".");
                result = s.Insert(3, ".").Insert(8, "");
            }


            return result;
        }
        public static string StringCalc07(string s)
        {
            string result = "Invalid input";
            string substr = "Pioneer";
            substr = substr.ToLower();
            bool b = s.Contains(substr);
            if (b == true)
                result = "Found";
            return result;
        }
        public static string StringCalc08(string s)
        {
            string result = "Invalid input";
            int index = s.IndexOf(',');
            result = s.Substring(14);


            return result;
        }
        public static string StringCalc09(string s)
        {
            string result = "Invalid input";
            int index = s.LastIndexOf(" ");
            result = s.Substring(22);

            return result;
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            string result = "Invalid input";



            return result;
        }

    }
}