using Crud_Mongodb.Models;

namespace Crud_Mongodb.Services
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string Id);
        Student Create(Student student);
        void Update(string id, Student student);
        void Remove(string id);
    }

}