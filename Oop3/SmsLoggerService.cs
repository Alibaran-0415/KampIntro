using System;

namespace Oop3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms loglandı.");
        }
    }
}
