using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dalmARTSY_Test.Models;

namespace dalmARTSYapi.Data
{
    public class dalmARTSYapiContext : DbContext
    {
        public dalmARTSYapiContext (DbContextOptions<dalmARTSYapiContext> options)
            : base(options)
        {
        }

        public DbSet<dalmARTSY_Test.Models.Product> Product { get; set; } = default!;
    }
}
