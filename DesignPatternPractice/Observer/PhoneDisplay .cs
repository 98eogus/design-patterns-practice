using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer
{
    public class PhoneDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"[핸드폰 화면] 새로운 온도: {temperature}°C");
        }
    }
}
