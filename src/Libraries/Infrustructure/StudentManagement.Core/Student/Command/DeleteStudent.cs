using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Command;


public record DeleteStudent (int Id):IRequest<VmStudent>;
public class DeleteStudentHandler : IRequestHandler<DeleteStudent, VmStudent>
{
    private readonly IStudentRepository _studentRepository;
    public DeleteStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<VmStudent> Handle(DeleteStudent request, CancellationToken cancellationToken)
    {   await _studentRepository.Delete(request.Id);
        return new VmStudent();
    }
}
