namespace RepoLibrary
{
    public class LocalRepository<T> : AJsonRepository<T>
    {
        public LocalRepository(string path)
        {
            string json = System.IO.File.ReadAllText(path);

            ConsumeData(json);
        }
    }
}