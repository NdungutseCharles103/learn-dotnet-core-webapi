namespace Crud_Mongodb.Models;

public interface IStudentStoreDatabaseSettings
{
    public string ConnectionString { get; set; }

    public string DatabaseName { get; set; }

    public string StudentCoursesCollectionName { get; set;}
}