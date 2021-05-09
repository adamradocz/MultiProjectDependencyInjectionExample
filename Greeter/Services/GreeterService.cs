namespace Greeter.Services
{
    public class GreeterService : IGreeterService
    {
        private readonly string _greeting;

        public GreeterService()
        {
            _greeting = "Hello from Greeter Library.";
        }

        public string Greet()
        {
            return _greeting;
        }
    }
}
