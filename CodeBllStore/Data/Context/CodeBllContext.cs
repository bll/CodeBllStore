using CodeBllStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBllStore.Data.Context
{
    public class CodeBllContext : DbContext
    {
        public CodeBllContext(DbContextOptions<CodeBllContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
