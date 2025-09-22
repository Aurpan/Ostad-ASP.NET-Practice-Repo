using AspDotNetAdvanced.Models;
using AspDotNetAdvanced.Services;
using AspDotNetAdvanced.Utilities;
using System.ComponentModel.DataAnnotations;

namespace AspDotNetAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lambda Function / Expression
            // inline function/method definition

            // Delegate => Func, Action, Predicate

            //Func<int, int> square = (num) => num * num;

            //BookService bookService = new BookService();
            //bookService.LambdaDemo(5, square);


            //Func<Book, string> colFinder = (book) => book.Author.ToString();
            //BookService bookService = new BookService();
            //bookService.GetCommaSeparatedValue(colFinder);
            //bookService.GetCommaSeparatedValue(book => book.Author.ToString()); // same as above line



            // Extension Method
            // .MethodName()


            // Generics
            //BookService bookService = new BookService();
            //Func<Book, string> colFinder = (book) => book.Author;
            //var result = bookService.GetCommaSeparatedValue(colFinder);

            //EmployeeService employeeService = new EmployeeService();
            //Func<Employee, string> empColFinder = (emp) => emp.Name;
            //var empResult = employeeService.GetCommaSeparatedValue(empColFinder);

            //Console.WriteLine("Here are the authors:");
            //Console.WriteLine(result);

            //Console.WriteLine("Here are the employees:");
            //Console.WriteLine(empResult);


            //var nums = new List<int>() { 10, 20, 30, 40, 50 };
            //nums.GetCommaSeparatedValue(num => num.ToString()); // error because int is not a class

            //var strs = new List<string>() { "Hello", "World", "From", "CSharp" };
            //strs.GetCommaSeparatedValue(str => str.ToString()); // error because string is not a class

            //var books = new List<Book>();
            //books.GetCommaSeparatedValue(book => book.Title);

            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Amir";
            emp.Salary = 700000;

            var context = new ValidationContext(emp);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(emp, context, results, true);

        }
    }
}
