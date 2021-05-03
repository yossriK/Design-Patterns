using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Writes;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _dataAccess;

        public InsertPersonHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        } 

        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
