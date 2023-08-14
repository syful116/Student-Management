using StudentManagement.Shared.Common;

namespace StudentManagement.Services.Model;

public class VmTeacher:IVm
{
    public int Id { get; set; }
    public string? TeacherName { get; set; }
    public double Salary { get; set; }
    public string? Department { get; set; }
}
