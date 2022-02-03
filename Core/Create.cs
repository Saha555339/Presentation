using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
using DatabaseContext;

namespace Core
{
    public class Create<T> where T:BaseEntity
    {
        private DataContext DContext { get; set; }
        public Create(DataContext dContext)
        {
            DContext = dContext;
        }
        public void Add(T entity)
        {
            DContext.Set<T>().Add(entity);
        }
        
    }
}
