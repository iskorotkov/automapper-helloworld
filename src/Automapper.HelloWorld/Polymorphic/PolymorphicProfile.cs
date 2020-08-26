using AutoMapper;

namespace Automapper.HelloWorld.Polymorphic
{
    public class PolymorphicProfile : Profile
    {
        public PolymorphicProfile()
        {
            CreateMap<Source, Destination>()
                .Include<SourceChild, DestinationChild>();

            CreateMap<SourceChild, DestinationChild>();
        }
    }
}