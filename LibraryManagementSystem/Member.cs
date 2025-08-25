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
        private int Age { get; set; } // only accessible within this class

        public void Register()
        {
            Console.WriteLine("Registering the member!");
        }

        protected void CancelToken()
        {
            Console.WriteLine("Cancel token money!");
        }

    }
}
