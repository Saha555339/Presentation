using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{
    public class Configuration
    {
        public string ConnectionString { get; private set; } = "Host=localhost;Port=5432;Database=newdb;Username=postgres;Password=postgres";
    }
}
