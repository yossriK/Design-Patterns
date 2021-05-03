using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Writes
{
    // this will create properties based on those names down here FirstName and LastName
    public record InsertPersonCommand(string FirstName, string LastName): IRequest<PersonModel>;


    // This is the class approach
    //public class InsertPersonCommand : IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertPersonCommand(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}
