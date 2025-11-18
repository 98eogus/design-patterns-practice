using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer
{
    public class TvDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"[TV 화면] 온도 업데이트: {temperature}°C");
        }
    }
}
