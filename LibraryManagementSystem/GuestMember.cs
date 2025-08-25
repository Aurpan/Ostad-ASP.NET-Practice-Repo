namespace LibraryManagementSystem
{
    public class GuestMember : Member // child : parent // derived class : base class
    {
        public double TokenMoney { get; set; }

        public void ShowProtectedExample(double amount)
        {
            GuestMember guest = new GuestMember();
            guest.CancelToken();
        }
    }
}
