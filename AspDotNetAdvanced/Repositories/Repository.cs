namespace AspDotNetAdvanced.Repositories
{
    public class Repository
    {
        public T Get<T>()
        {
            return default(T);
        }

        public void Delete<T>(int id)
        {
            //T.Delete(t => t.id == id);
        }
    }
}
