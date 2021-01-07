using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hrincescu_Alexandru_Lab6.Models;

namespace Hrincescu_Alexandru_Lab6.Data
{
    public class Hrincescu_Alexandru_Lab6Context : DbContext
    {
        public Hrincescu_Alexandru_Lab6Context (DbContextOptions<Hrincescu_Alexandru_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Hrincescu_Alexandru_Lab6.Models.Book> Book { get; set; }
    }
}
