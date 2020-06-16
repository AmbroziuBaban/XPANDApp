using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext :DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {            
        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<DescriptionRobot> DescriptionRobots { get; set; }
        public  DbSet<Robot> Robots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RobotConfiguration());
        }
    }
}
