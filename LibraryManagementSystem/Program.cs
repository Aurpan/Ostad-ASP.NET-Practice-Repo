using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class: Book, Member, Librarian
            // Encapsulation =>
            // Access Modifiers => public, private, protected, internal
            Book book = new Book(DateTime.Now);

            //book.Title = "C# Programming";
            //book.Author = "John Doe";
            //book.Category = "Programming";
            //book.CollectionDate = DateTime.Now;
            ////book.AvailableBooks = 5;
            //book.GetBookCount();
            //book.Borrow();
            //book.GetBookCount();




            // Inheritance =>
            //StudentMember student = new StudentMember();
            //student.Name = "Alice";
            //student.MemberID = 1;
            //student.MemberType = MemberTypeEnum.Student;

            //TeacherMember teacher = new TeacherMember();
            //teacher.Name = "Bob";
            //teacher.MemberID = 2;
            //teacher.MemberType = MemberTypeEnum.Teacher;


            //GuestMember guest = new GuestMember();
            //guest.Name = "Charlie"; 
            //guest.MemberID = 3;
            //guest.MemberType = MemberTypeEnum.Guest;

            Member studentMember = new StudentMember();
            Member teacherMember = new TeacherMember();
            Member guestMember = new GuestMember();

            Librarian librarian = new Librarian();

            List<Member> members = new List<Member>();
            members.Add(studentMember);
            members.Add(teacherMember);
            members.Add(guestMember);

            librarian.GetAllMembers(members);

            // example of protected access modifier
            GuestMember guest = new GuestMember();
            //guest.CancelToken();
            guest.Age = 25;
        }
    }
}
