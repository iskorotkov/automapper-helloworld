namespace Automapper.HelloWorld.Polymorphic
{
    public class Source
    {
        public int Id = 1;
    }

    public class SourceChild : Source
    {
        public string Name = nameof(SourceChild);
    }
}