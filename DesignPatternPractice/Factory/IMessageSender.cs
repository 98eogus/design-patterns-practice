using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Factory
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
