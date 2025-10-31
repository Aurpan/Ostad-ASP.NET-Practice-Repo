using AspDotNetAdvanced.Models;
using System.Runtime.CompilerServices;

namespace AspDotNetAdvanced.Utilities
{
    // extension methods must be defined in a static class
    public static class ExtensioMethods 
    {
        // Non-generic extension method
        [Obsolete("Please use the new one - GetCommaSeparatedValue<T>(this List<T> objects, Func<T, string> colCondition)")]
        public static string GetCommaSeparatedValues(this List<Employee> books, Func<Employee, string> colCondition)
        {
            List<string> strValues = new List<string>();
            foreach (var book in books)
            {
                var value = colCondition(book);
                if (value != null)
                {
                    strValues.Add(value.ToString());
                }
            }

            return string.Join(", ", strValues);
        }



        // Generic extension method
        public static string GetCommaSeparatedValue<T>
            (this List<T> objects, Func<T, string> colCondition) where T : class, new() // INumber<T>
        {
            List<string> strValues = new List<string>();
            foreach (var obj in objects)
            {
                var value = colCondition(obj);
                if (value != null)
                {
                    strValues.Add(value.ToString());
                }
            }

            return string.Join(", ", strValues);
        }

        public static decimal GetSum(this List<decimal> nums)
        {
            decimal sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return sum;
        }

        public static void PrintDecimal(this decimal num)
        {
            Console.WriteLine(num);
        }

        public static decimal GetSumNormal(List<decimal> nums)
        {
            decimal sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return sum;
        }

        //public static decimal GetSum<T>(this List<T> nums)
        //{
        //    decimal sum = 0;
        //    foreach (var num in nums)
        //    {
        //        sum += num;
        //    }

        //    return sum;
        //}
    }
}
