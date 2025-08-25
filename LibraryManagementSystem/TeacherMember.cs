namespace LibraryManagementSystem
{
    public class TeacherMember : Member // child : parent // derived class : base class
    {
        public void ShowProtectedExample(double amount)
        {
            TeacherMember guest = new TeacherMember();
            guest.CancelToken();
        }
    }
}
