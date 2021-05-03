using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "John", LastName = "Smith" });
            people.Add(new PersonModel { Id = 2, FirstName = "Wild", LastName = "Card" });
        }

        // typically this will be retrieved for database using dapper lets say
        public List<PersonModel> GetPeople()
        {
            return people;
        }

        // typically this will be inserted into a database
        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
