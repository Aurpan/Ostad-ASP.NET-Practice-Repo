namespace LearningCSharp
{
    public class Employee
    {
        // class is a complex data type
        // properties => fields/variables
        // behaviour => methods

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        private string PhoneNumber { get; set; }
        public int CompanyEstablishmentYear { get; set; } // wrong approach, shouldn't be here

        public void CompleteTask(string taskName)
        {
            Console.WriteLine(taskName + " is complete!");
        }
    }
}
