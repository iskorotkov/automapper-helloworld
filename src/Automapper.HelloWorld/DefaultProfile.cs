using AutoMapper;

namespace Automapper.HelloWorld
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<A, B>();
        }
    }
}