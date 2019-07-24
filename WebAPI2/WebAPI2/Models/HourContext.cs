using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class HourContext : DbContext
    {
       
        public HourContext(DbContextOptions<HourContext> options):base(options)
        {

        }

        public DbSet<HourDetail> HourDetails { get; set; }
    }
}
