﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class Context : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}