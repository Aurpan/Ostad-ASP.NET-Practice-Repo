using AspDotNetAdvanced.Attributes;

namespace AspDotNetAdvanced.Models
{
    public class Employee
    {
        [Amar]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }

        [SalaryValidation(10000, 50000, "Salary is not in Range!")]
        public int Salary { get; set; }
    }
}
