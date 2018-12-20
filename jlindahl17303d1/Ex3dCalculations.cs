using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jlindahl17303d1
{
   public class Ex3dCalculations
    {
        

        public static string ArrayToString(int[] values)
        {
            //use the StringBuilder class  for string-handling routines that append, insert, 
            //remove or replace characters in strings,
            // especially if working w/ long strings that use lots of system resources.
            //using the Remove, Replace, Insert methods changes the existing string instead of giving you a new string.

            // Create StringBuilder object: sbResult
            // loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result

            
            string values1 = "";
            StringBuilder sbResult = new StringBuilder(values1);

            foreach(int value in values)
            
                values1 += value + ", ";
                string result1 = values1.ToString();
            string result = result1.Remove(83, 2);
                return result;
            
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter
            int count = 0;
            foreach (int value in values)
                if (value == searchValue)
                    count += value;
            int counter = count;
            return counter;
        }

        internal static string RangeCount(int[] values, string strSearchMin, string strSearchMax)
        {
            throw new NotImplementedException();
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;
            foreach (int value in values)
                if (value <= searchMin && value >= searchMax)
                    count += value;
            int counter = count;
            return counter;
        }

    }
}
