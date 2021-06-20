namespace SingletonPattern
{
    // this implementation drastically reduces overhead and improves performance
    public class DclSingleton
    {
        // The volatile keyword ensures that multiple threads handle the uniqueInstance variable correctly when it is being initialized to the Singleton instance.
        private volatile static DclSingleton _UniqueInstance;

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement
        private static readonly object SyncLock = new object();


        public static DclSingleton Instance
        {
            get
            {
                if (_UniqueInstance == null)
                {
                    lock (SyncLock)
                    {
                        if (_UniqueInstance == null)
                        {
                            _UniqueInstance = new DclSingleton();
                        }
                    }
                }
                return _UniqueInstance;
            }
        }

        private DclSingleton() { }

    }
}
