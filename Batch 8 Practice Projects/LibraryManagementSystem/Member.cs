using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem
{
    public class Member //: Example
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string MembershipCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Email { get; set; }
        public MemberTypeEnum MemberType { get; set; }
        public static int MemberCount { get; set; } // belongs to class not object
        public static List<Book> BorrowedBook { get; set; }

        //private int Age { get; set; } // only accessible within this class

        public virtual void Register()
        {
            Console.WriteLine("Registering a member!");

            Book book = new Book();
            book.GetBookCount();
        }

        //protected void CancelToken()
        //{
        //    Console.WriteLine("Cancel token money!");
        //}

        //public static void ShowCount()
        //{
        //    Console.WriteLine("Total Members: " + MemberCount);
        //}

    }
}
