using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy
{
    public interface IStringSorter
    {
        List<string> Sort(List<string> list);
    }
}
