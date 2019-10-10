using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkerCRUD.Models
{
    public class WorkerContext : DbContext
    {
        public DbSet<Worker> Worker { get; set; }

        public WorkerContext(DbContextOptions<WorkerContext> options)
            : base(options)
        {
        }
    }
}
