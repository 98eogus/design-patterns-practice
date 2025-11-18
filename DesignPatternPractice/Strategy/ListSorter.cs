using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy
{
    public class ListSorter
    {
        private IStringSorter _sortStrategy;

        public void SetStrategy(IStringSorter strategy)
        {
            _sortStrategy = strategy;
        }

        public List<string> Sort(List<string> list)
        {
            return _sortStrategy.Sort(list);
        }
    }
}
