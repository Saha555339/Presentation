using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class Delete<T> where T:BaseEntity
    {
        private DataContext DContext { get; set; }
        public Delete(DataContext dContext)
        {
            DContext = dContext;
        }
        public void Del(int id)
        {
            var t = DContext.Set<T>().Where(s => s.Id == id).ToList();
            if (t.Count == 0)
                throw new Exception("Поля с таким ID не существует");
            else
                DContext.Set<T>().RemoveRange(t);
        }
        public void DelAll()
        {
            DContext.Set<T>().RemoveRange();
        }
    }
}
