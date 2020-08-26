namespace Automapper.HelloWorld.Nested
{
    public class Source
    {
        public int Id { get; set; } = 1;
        public InnerSource Inner { get; set; } = new InnerSource();
    }

    public class InnerSource
    {
        public int Id { get; set; } = 2;
    }
}