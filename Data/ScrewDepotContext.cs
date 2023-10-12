using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ScrewDepot.Models;

namespace ScrewDepot.Data
{
    public class ScrewDepotContext : DbContext
    {
        public ScrewDepotContext(DbContextOptions<ScrewDepotContext> options)
            : base(options)
        {
        }


        public DbSet<ScrewsModel> ScrewsModel { get; set; }
    }

   
}
