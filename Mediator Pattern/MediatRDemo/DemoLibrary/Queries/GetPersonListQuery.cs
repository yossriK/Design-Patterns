using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    // we said query at end to differentiate and
    // we also changed from class to record: that are classes but got additiaonal syntax sysntax, as in you create them one but
    // editing them
    // notice how we implemented the interface IRequest, and how it has the out parameter of a lsit

    // every query should have one handler
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    // in case I wanted a class form, I can do 
    //public class GetPersonListQueryClass: IRequest<List<PersonModel>>{}
}
