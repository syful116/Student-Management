using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Command;

public record CreateTecher(VmTeacher VmTeacher):IRequest<VmTeacher>;
public class CreateTeacherHandler : IRequestHandler<CreateTecher, VmTeacher>
{
    private readonly ITeacherRepository _teacherRepository;
    private readonly IMapper _mapper;
    public CreateTeacherHandler(ITeacherRepository teacherRepository, IMapper mapper)
    {
        _teacherRepository = teacherRepository;
        _mapper = mapper;
     
    }

    public async Task<VmTeacher> Handle(CreateTecher request, CancellationToken cancellationToken)
    {
        var data=_mapper.Map<Model.Teacher>(request.VmTeacher);
        return await _teacherRepository.Add(data);
    }
}




