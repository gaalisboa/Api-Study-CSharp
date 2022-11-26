using RestWithASPUdemy.src.Models;

namespace RestWithASPUdemy.src.Services
{
    public interface IPersonService
    {
        public Person Create(Person person);
        List<Person> GetAll();
        public Person GetById(long id);
        public Person Update(Person person);
        public void Delete(long id);
    }
}