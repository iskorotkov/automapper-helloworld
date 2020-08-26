using AutoMapper;
using Automapper.HelloWorld.Flattened;

namespace Automapper.HelloWorld
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Source, Destination>()
                .ForMember(dest => dest.Y, opt => opt.MapFrom(src => src.X))
                .ForMember(dest => dest.NotMapped, opt => opt.Ignore());
        }
    }
}