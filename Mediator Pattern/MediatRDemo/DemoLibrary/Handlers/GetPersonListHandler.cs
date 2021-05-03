using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    // handling the query, I pass which query i want to handle, and if we got any return stuff to worry about/output

    // This is like the useCase I had at work, just a different name here

    // we can instantiate this class without mediatR, and can test it easilty just the handle it self
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        // only our handler will know about data access
        private readonly IDataAccess _data;
        // dependency injection was involved here, Mediator doesnot replace dependency injection, it just adds to it
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }


        // we have cancelation token as everything is async in Mediator
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            // task.fromResult() wrapps our result in a task, use when want some sync value to be returned async
            return Task.FromResult(_data.GetPeople());
        }
    }
}
