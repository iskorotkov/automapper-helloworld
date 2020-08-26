namespace Automapper.HelloWorld.Polymorphic
{
    public class Destination
    {
        public int Id;
    }

    public class DestinationChild : Destination
    {
        public string Name;
    }
}