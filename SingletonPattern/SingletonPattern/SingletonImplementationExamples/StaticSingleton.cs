namespace SingletonPattern
{
    // this is hte another example of creating a thread safe implementation of singleton class
    public class StaticSingleton
    {
        public static StaticSingleton Instance { get; } = new StaticSingleton();

        private StaticSingleton() { }
    }
  
}
