namespace SingletonPattern
{
    // those singleton classes can be subclassed but the constructors got to be protected instead of private in base
    public class Singleton
    {
        // this is not thread safe implementation of the class, as two thread might get to the point of creating instance and thus end up with two instances instead of one
        private static Singleton _UniqueInstance;

        // private constructor, only this class can use it
        private Singleton() { }

        // this is static, => Class method, so we use class name S
        public static Singleton Instance => _UniqueInstance ??= new Singleton();
    }
}
