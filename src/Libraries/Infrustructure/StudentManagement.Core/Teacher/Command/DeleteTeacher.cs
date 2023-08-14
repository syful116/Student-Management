using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Teacher.Command;

public record DeleteTeacher(int Id):IRequest<VmTeacher>;

public class DeleteTeacherHandler : IRequestHandler<DeleteTeacher, VmTeacher>
{
    private readonly ITeacherRepository _TeacherRepository;
    public DeleteTeacherHandler(ITeacherRepository teacherRepository)
    {
        _TeacherRepository = teacherRepository;
    }

    public async Task<VmTeacher> Handle(DeleteTeacher request, CancellationToken cancellationToken)
    {
         await _TeacherRepository.Delete(request.Id);
        return new VmTeacher();

    }
}
