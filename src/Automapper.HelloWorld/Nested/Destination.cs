namespace Automapper.HelloWorld.Nested
{
    public class Destination
    {
        public int Id { get; set; }
        public InnerDestination Inner { get; set; }
    }

    public class InnerDestination
    {
        public int Id { get; set; }
    }
}