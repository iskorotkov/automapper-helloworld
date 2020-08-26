using AutoMapper;
using Automapper.HelloWorld.Polymorphic;
using Shouldly;
using Xunit;

namespace Automapper.HelloWorld.Tests
{
    public class MapperTests
    {
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;

        public MapperTests()
        {
            _config = new MapperConfiguration(MapperExtensions.ConfigureMapper);
            _mapper = _config.CreateMapper();
        }

        [Fact]
        public void CheckMapperConfiguration()
        {
            _config.AssertConfigurationIsValid();
        }

        [Fact]
        public void PolymorphicTypesShouldMapCorrectly()
        {
            var from = new[]
            {
                new Polymorphic.Source(),
                new Polymorphic.SourceChild()
            };

            var to = _mapper.Map<Polymorphic.Source[], Polymorphic.Destination[]>(from);

            to.Length.ShouldBe(2);

            to[0].ShouldBeOfType<Polymorphic.Destination>();
            to[1].ShouldBeOfType<Polymorphic.DestinationChild>();

            to[0].Id.ShouldBe(1);
            to[1].Id.ShouldBe(1);
            ((DestinationChild) to[1]).Name.ShouldBe(nameof(Polymorphic.SourceChild));
        }
    }
}