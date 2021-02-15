using Proto;
using Proto.Remote;

namespace ServerMine
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = new ActorSystem();

            var serialization = new Serialization();
            var context = new RootContext(system);
            serialization.RegisterFileDescriptor(ChatReflection.Descriptor);
            var remote = new Remote(system, serialization);
            remote.Start("127.0.0.1", 8000);

            var clients = new HashSet<PID>();
        }
    }
}
