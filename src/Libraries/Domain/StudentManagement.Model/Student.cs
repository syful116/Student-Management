using StudentManagement.Shared;
using StudentManagement.Shared.Common;

namespace StudentManagement.Model;

public class Student:BaseEntity,IEntity
{
    public string? StudentName { get; set; }
    public double AddmissionFee { get; set;}

    //[MaxLength(50)]
    public string? CourseName { get; set; }
    public int Id { get; set; }
}
