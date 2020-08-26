using AutoMapper;

namespace Automapper.HelloWorld.Flattening
{
    public class FlatteningProfile : Profile
    {
        public FlatteningProfile()
        {
            CreateMap<Task, TaskDto>()
                .IncludeMembers(task => task.Project);
            CreateMap<Project, TaskDto>(MemberList.None);
        }
    }
}