using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Command;


public record UpdateTeacher(int Id,VmTeacher VmTeacher):IRequest<VmTeacher>;

public class UpdateTeacherHandler : IRequestHandler<UpdateTeacher,VmTeacher>
{
    private readonly ITeacherRepository _teacherRepository;
    private readonly IMapper _mapper;
    public UpdateTeacherHandler(ITeacherRepository teacherRepository, IMapper mapper)
    {
        _teacherRepository = teacherRepository;
        _mapper = mapper;
    }

    public async Task<VmTeacher> Handle(UpdateTeacher request, CancellationToken cancellationToken)
    {

       
        var data = _mapper.Map<Model.Teacher>(request.VmTeacher);
        
        return await _teacherRepository.Update(request.Id,data);
    }
}
