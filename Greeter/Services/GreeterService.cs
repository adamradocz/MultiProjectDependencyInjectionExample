using System;

namespace Greeter.Services
{
    public class GreeterService : IGreeterService
    {
        private readonly string _greeting;

        private readonly IInternalGreeterService _internalGreeterService;

        public GreeterService(IInternalGreeterService internalGreeterService)
        {
            _greeting = "Hello from Greeter Library.";

            _internalGreeterService = internalGreeterService ?? throw new NullReferenceException(nameof(internalGreeterService));
        }

        public string Greet()
        {
            return _greeting + _internalGreeterService.InternalGreet();
        }
    }
}
