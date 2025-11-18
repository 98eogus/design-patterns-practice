using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Factory
{
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS 전송: {message}");
        }
    }
}
