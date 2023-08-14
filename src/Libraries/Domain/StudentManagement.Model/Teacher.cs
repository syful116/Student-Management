using StudentManagement.Shared;
using StudentManagement.Shared.Common;

namespace StudentManagement.Model;

public class Teacher:BaseEntity,IEntity
{
    public string? TeacherName { get; set; }
    public double Salary { get; set; }
    public string? Department { get; set; }
    public int Id { get ; set; }
}
