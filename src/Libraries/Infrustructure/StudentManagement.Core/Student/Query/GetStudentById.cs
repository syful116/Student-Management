using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Query;

public record GetStudentById(int id):IRequest<VmStudent>;
public class GetStudentByIdHandler :
IRequestHandler<GetStudentById, VmStudent>
{
    private readonly IStudentRepository _studentRepository;
    public GetStudentByIdHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<VmStudent> Handle(GetStudentById request, CancellationToken cancellationToken)
    {
        return await _studentRepository.GetById(request.id);
    }
}
