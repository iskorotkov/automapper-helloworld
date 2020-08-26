using System.Reflection;
using AutoMapper;

namespace Automapper.HelloWorld
{
    public static class MapperExtensions
    {
        public static void ConfigureMapper(this IMapperConfigurationExpression config)
        {
            config.AddMaps(Assembly.GetExecutingAssembly());

            config.SourceMemberNamingConvention = new PascalCaseNamingConvention();
            config.DestinationMemberNamingConvention = new PascalCaseNamingConvention();

            config.ReplaceMemberName("FromName", "ToName");

            config.RecognizePrefixes("Prefix", "Pre");
            config.RecognizeDestinationPostfixes("Postfix");
        }
    }
}