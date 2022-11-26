using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASPUdemy.src.Models;

namespace RestWithASPUdemy.src.Services.Implementations
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 5; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person GetById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Gabriel",
                LastName = "Lisboa",
                Address = "São José dos Campos - São Paulo - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = i,
                FirstName = "Gabriel",
                LastName = "Lisboa",
                Address = "São José dos Campos - São Paulo - Brasil",
                Gender = "Male"
            };
        }
    }
}