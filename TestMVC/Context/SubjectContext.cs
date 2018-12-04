using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestMVC.Models;

namespace TestMVC.Context
{
    public class SubjectContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
    }
}