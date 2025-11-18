using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy
{
    public class DescendingSorter : IStringSorter
    {
        public List<string> Sort(List<string> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
