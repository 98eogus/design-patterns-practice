using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Builder
{
    public class SqlQueryBuilder
    {
        private string _select;
        private string _from;
        private string _where;
        private string _orderBy;

        public SqlQueryBuilder Select(string select)
        {
            _select = select;
            return this;
        }

        public SqlQueryBuilder From(string from)
        {
            _from = from;
            return this;
        }

        public SqlQueryBuilder Where(string where)
        {
            _where = where;
            return this;
        }

        public SqlQueryBuilder OrderBy(string orderBy)
        {
            _orderBy = orderBy;
            return this;
        }

        public string Build()
        {
            return $"SELECT {_select} FROM {_from} " +
                   $"{(_where != null ? $"WHERE {_where}" : "")} " +
                   $"{(_orderBy != null ? $"ORDER BY {_orderBy}" : "")}";
        }
    }

}
