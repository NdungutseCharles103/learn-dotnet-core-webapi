namespace Crud_Mongodb.Models;

public class StudentStoreDatabaseSettings: IStudentStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = String.Empty;

    public string DatabaseName { get; set; } = String.Empty;

    public string StudentCoursesCollectionName { get; set;} = String.Empty;
}