using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
using DatabaseContext;

namespace Core
{
    public class Edit<T> where T : BaseEntity
    {
        private DataContext DContext { get; set; }
        public Edit(DataContext dContext)
        {
            DContext = dContext;
        }
        public List<T> Edits()
        {
            var _edits = DContext.Set<T>().ToList();
            return _edits;
        }
    }
}
