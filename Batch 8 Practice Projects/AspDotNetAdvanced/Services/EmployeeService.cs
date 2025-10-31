using AspDotNetAdvanced.Models;
using AspDotNetAdvanced.Repositories;
using AspDotNetAdvanced.Utilities;

namespace AspDotNetAdvanced.Services
{
    public class EmployeeService
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Designation = "Software Engineer" },
            new Employee { Id = 2, Name = "Bob Smith", Designation = "Project Manager" },
            new Employee { Id = 3, Name = "Charlie Brown", Designation = "QA Analyst" },
            new Employee { Id = 4, Name = "Diana Prince", Designation = "UX Designer" },
            new Employee { Id = 5, Name = "Ethan Hunt", Designation = "DevOps Engineer" }
        };

        public string GetCommaSeparatedValue(Func<Employee, string> colCondition)
        {
            //return _employees.GetCommaSeparatedValue(colCondition);
            return _employees.GetCommaSeparatedValues(colCondition);
        }

        public Employee GetAll()
        {
            var repo = new Repository();
            return repo.Get<Employee>();
        }
    }
}
