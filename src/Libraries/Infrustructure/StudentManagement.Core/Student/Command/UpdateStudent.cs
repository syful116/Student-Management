using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Command;


public record UpdateStudent(int Id,VmStudent VmStudent):IRequest<VmStudent>;
public class UpdateStudentHandler : IRequestHandler<UpdateStudent,VmStudent>
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public UpdateStudentHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<VmStudent> Handle(UpdateStudent request, CancellationToken cancellationToken)
    {
        var data=_mapper.Map<Model.Student>(request.VmStudent);
        return await _studentRepository.Update(request.Id,data);
    }
}
