using Microsoft.Extensions.Logging;

namespace Vitorm.Hugin.Console
{
    public class ConsoleApplication
    {
        private readonly ILogger<ConsoleApplication> _logger;
        
        public ConsoleApplication(ILogger<ConsoleApplication> logger)
        {
            _logger = logger;
        }
        
        public void Run()
        {
            
        }
    }
}