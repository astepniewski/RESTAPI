using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class ApplicationContext : DbContext
    {
  
        public ApplicationContext() : base("name=RestApiContext")
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
