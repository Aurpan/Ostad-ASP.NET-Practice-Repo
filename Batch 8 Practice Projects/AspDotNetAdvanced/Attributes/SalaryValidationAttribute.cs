using System.ComponentModel.DataAnnotations;

namespace AspDotNetAdvanced.Attributes
{
    public class SalaryValidationAttribute : ValidationAttribute
    {
        public int Max { get; set; }
        public int Min { get; set; }

        public SalaryValidationAttribute(int min, int max, string msg)
        {
            Max = max;
            Min = min;
            ErrorMessage = msg;
        }

        public override bool IsValid(object? value)
            {
            if (value is not null && value is int salary)
            {
                if (salary < Max && salary > Min)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
