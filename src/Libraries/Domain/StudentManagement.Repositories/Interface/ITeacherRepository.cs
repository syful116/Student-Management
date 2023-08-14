using StudentManagement.Infrustructure.CommonRepository;
using StudentManagement.Model;
using StudentManagement.Services.Model;

namespace StudentManagement.Repositories.Interface;

public interface ITeacherRepository : IRepository<Teacher,VmTeacher,int>

{

}
