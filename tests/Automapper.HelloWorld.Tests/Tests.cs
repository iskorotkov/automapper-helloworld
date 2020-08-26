using AutoMapper;
using Xunit;

namespace Automapper.HelloWorld.Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var config = new MapperConfiguration(MapperExtensions.ConfigureMapper);
            config.AssertConfigurationIsValid();
        }
    }
}