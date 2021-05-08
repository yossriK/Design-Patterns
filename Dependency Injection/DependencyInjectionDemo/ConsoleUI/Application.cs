using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }


        // will call this from program.cs/ we added this class here as we initially had
        // business logic in program.cs but cant instantiate it with out using 'new' which we were avoiding, 
        // so creating like a middle man to create noew business logic and run our small app
        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
