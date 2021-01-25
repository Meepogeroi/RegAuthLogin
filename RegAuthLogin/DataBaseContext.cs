using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RegAuthLogin.db.models;

namespace RegAuthLogin.db
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext(): base("DbConnect"){}

        public DbSet<User> Users { get; set; }
    }
}
