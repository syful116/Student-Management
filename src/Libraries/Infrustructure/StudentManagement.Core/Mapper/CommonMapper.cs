using AutoMapper;


namespace StudentManagement.Core.Mapper;

public class CommonMapper:Profile
{
    public CommonMapper()
    {
       CreateMap<Services.Model.VmStudent,Model.Student>().ReverseMap();
        CreateMap<Services.Model.VmTeacher, Model.Teacher>().ReverseMap();
    }


}
