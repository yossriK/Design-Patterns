using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();


            // now this is interesting, we had businessLogic created by new() here and we didnt want that
            // set up a new scope for container
            using (var scope = container.BeginLifetimeScope())
            {

                // ?I need an IApplication object, this goes to container, uses that to get IApplication manually
                // if this methd was used extensively then somethign is wrong in way your app is designed, 
                // should onlybe used once for initial hook
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
