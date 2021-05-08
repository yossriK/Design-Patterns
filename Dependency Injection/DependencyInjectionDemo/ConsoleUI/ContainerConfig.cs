using Autofac;
using DemoLibrary;
using System.Linq;
using System.Reflection;

namespace ConsoleUI
{
    // based on dependency inversion principle, the top level object will control all our dependencies, 
    // in the top we mean our program cs, which is outer layer, it would control how we wire the dependencies and instantiatoin


    // wiriing/configuring  the container
    // think of container as place to store the definitions of all classes we want to intantiate in this case
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            // build container/ or gives us a container instance that we can assemble for us
            var builder = new ContainerBuilder();

            // telling container to register stuff for us
            // btw: here it would new stuff up for us whenever we need, there are methods to create one instance for all the app
            // like addSingleton, or OnePerInstance iu52
            builder.RegisterType<Application>().As<IApplication>();

            // simple registeration, class in demo library, when ever someone needs
            // IBusinessLogic give them back the betterbusinessLogic concrete class

            // wiring interface to application
            // I can keep interface, and chagne the concrete class with no one affected (as long methods are the same ofcourse)
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            // instead of going one by one to register classes, we register the whole classes 
            // in an assembly. there is also other methods where it can register all classes to certain 
            // type in a folder.
            //(in demoLibrary, get folder utilites and register teh classes-interfaces

            // this hooking can be done in different ways, even cleaner than this
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));


            // builds the container using the assemblies/key-value pairs we just provided
            return builder.Build();
        }
    }
}
