namespace LibraryManagementSystem
{
    public interface IBook // is a contract
    {
        void Borrow(string collectionDate);
        void GetBookCount();
        void GetBookCount(string categoryName);
        void GetBookCount(string categoryName, int x);
        void GetBookCount(int x, string categoryName);
        void GetBookCount(int x);
    }
}
