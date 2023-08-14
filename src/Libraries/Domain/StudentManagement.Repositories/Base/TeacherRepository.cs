using AutoMapper;
using StudentManagement.Infrustructure;
using StudentManagement.Infrustructure.CommonRepository;
using StudentManagement.Model;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Repositories.Base;

public class TeacherRepository:RepositoryBase<Teacher,VmTeacher,int>, ITeacherRepository
{
    public TeacherRepository(IMapper mapper, StudentManagementDbContext dbContext) : base(mapper, dbContext)
    {

    }
}
