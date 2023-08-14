using MediatR;
using StudentManagement.Repositories.Base;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Query;

public record GetTeacherById(int Id):IRequest<VmTeacher>;
public class GetTeacherByIdHandler : IRequestHandler<GetTeacherById, VmTeacher>
{
    private readonly ITeacherRepository _teacherRepository;
    public GetTeacherByIdHandler (ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }
    public async Task<VmTeacher> Handle(GetTeacherById request, CancellationToken cancellationToken)
    {
        return await _teacherRepository.GetById(request.Id);
    }
}
