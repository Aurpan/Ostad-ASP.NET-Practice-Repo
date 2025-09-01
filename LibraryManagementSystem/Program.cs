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
            //Book book = new Book(DateTime.Now);

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

            //Member studentMember = new StudentMember();
            //Member teacherMember = new TeacherMember();
            //Member guestMember = new GuestMember();

            //Librarian librarian = new Librarian();

            //List<Member> members = new List<Member>();
            //members.Add(studentMember);
            //members.Add(teacherMember);
            //members.Add(guestMember);

            //librarian.GetAllMembers(members);

            //// example of protected access modifier
            //GuestMember guest = new GuestMember();
            ////guest.CancelToken();
            //guest.Age = 25;


            // what is Static!
            //Member m1 = new Member();
            //Member m2 = new Member();

            //m1.MemberID = 1;
            //m1.Name = "Alice";

            //m2.MemberID = 2;
            //m1.Name = "Bob";

            //Member.MemberCount = 100;

            //Member.ShowCount();
            ////m2.ShowCount(); // will show error



            // polymorphism => many forms
            // method overloading, method overriding
            //Book book = new Book();

            //book.GetBookCount();
            //book.GetBookCount("history");

            //Member member = new Member();
            ////Member gMember = new GuestMember();
            //GuestMember gMember = new GuestMember();
            //Member tMember = new TeacherMember();

            //member.Register();
            //gMember.Register();
            //tMember.Register();


            // Abstraction => hiding complexity
            IBook book = new Book(); // can't create object of interface
            book.Borrow("");
        }
    }
}
