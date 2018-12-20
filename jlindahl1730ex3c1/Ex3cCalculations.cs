using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jlindahl1730ex3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            //if (index >= 0 && index <= 8) <---- doesn't work
            //{
            //    return "Invalid index";
            //}

            //else
            //{
            //    int i = index - 1;
            //    string[] days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //    string day = days[i];
            //    return day;
            //}

            //if (index >= 0 || index <= 8)   <---- doesn't work
            //{
            //    return "Invalid index";
            //}

            //else
            //{
            //    int i = index - 1;
            //    string[] days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //    string day = days[i];
            //    return day;
            //}

            if (index <= 0 || index >= 8)
                return "Invalid index";

            else
            {
                int i = index - 1;
                string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                string day = days[i];
                return day;
            }
        }
        public static string Calc1(string search)

        {
            string search_1 = search.Trim();
            string search_2 = search_1.ToUpper();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search_2);
            string open = hours[index]; 
            if (index <= 0 && index >= 6)
            {
                return "Invalid input";
            }
            return open.ToString();
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;  
            foreach (int total in numbers)
            {
                sum += total;
            }
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            if (count > numbers.GetLength(0))
            {
                sum = 0.0;
            }
            else

            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
            }
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            int count = numbers.Length;
            double numbers01 = Calc3(numbers, count);
            double average = numbers01 / count;

            return average;
        }

        public static double Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveavgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (int number in numbers)

                    if (number >= avg)
                        aboveavgList.Add(number);
            }
                
                return aboveavgList.ToArray();
            
            
        }


    }
}


