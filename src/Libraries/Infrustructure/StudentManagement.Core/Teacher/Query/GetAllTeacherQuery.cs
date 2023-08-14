using MediatR;
using StudentManagement.Repositories.Base;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Query;


public record GetAllTeacherQuery():IRequest<IEnumerable<VmTeacher>>;
public class GetAllTeacherQueryHandler : IRequestHandler<GetAllTeacherQuery, IEnumerable<VmTeacher>>
{
    private readonly ITeacherRepository _TeacherRepository;

    public GetAllTeacherQueryHandler(ITeacherRepository TeacherRepository)
    {
        _TeacherRepository= TeacherRepository;
    }


    public async Task<IEnumerable<VmTeacher>> Handle(GetAllTeacherQuery request, CancellationToken cancellationToken)
    {
        var result = await _TeacherRepository.GetAll();
        return result;
    }
}
