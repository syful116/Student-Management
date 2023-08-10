using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Command;



public record CreateStudent(VmStudent Vmstudent):IRequest<VmStudent>;
public class CreateStudentHandler : IRequestHandler<CreateStudent, VmStudent>
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public CreateStudentHandler (IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }   

    public async Task<VmStudent> Handle(CreateStudent request, CancellationToken cancellationToken)
    {
        var data=_mapper.Map<Model.Student>(request.Vmstudent);
        return await _studentRepository.Add(data);
    }
}
