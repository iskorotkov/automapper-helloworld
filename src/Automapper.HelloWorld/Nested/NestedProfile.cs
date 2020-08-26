using AutoMapper;

namespace Automapper.HelloWorld.Nested
{
    public class NestedProfile : Profile
    {
        public NestedProfile()
        {
            CreateMap<InnerSource, InnerDestination>();
            CreateMap<Source, Destination>();
        }
    }
}