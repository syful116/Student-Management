using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Query;

//public record GetAllStudentQuery:IRequest<IEnumerable<VmStudent>>;
//public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, IEnumerable<VmStudent>>
//{

//    private readonly IStudentRepository _studentRepository;

//    public GetAllStudentQueryHandler(IStudentRepository studentRepository,IMapper mapper)
//    {
//        _studentRepository = studentRepository;
//    }
//    public async Task<IEnumerable<VmStudent>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
//    {
//        var result = await _studentRepository.GetAll();
//        return result;
//    }
//}

public record GetAlStudenQuray:IRequest<IEnumerable<VmStudent>>;
public class GetAllStudentHandeler : IRequestHandler<GetAlStudenQuray, IEnumerable<VmStudent>>{
    private readonly IStudentRepository _studentRepository;
    public GetAllStudentHandeler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
        
    }

    public async Task<IEnumerable<VmStudent>> Handle(GetAlStudenQuray request, CancellationToken cancellationToken)
    {
        var data = await _studentRepository.GetAll();

        return data;
    }
}
