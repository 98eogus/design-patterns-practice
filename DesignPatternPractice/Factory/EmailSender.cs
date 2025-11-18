using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Factory
{
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"이메일 전송: {message}");
        }
    }
}
