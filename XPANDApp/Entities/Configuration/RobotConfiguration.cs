using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class RobotConfiguration :IEntityTypeConfiguration<Robot>
    {
        public void Configure(EntityTypeBuilder<Robot> builder)
        {
            builder.HasData(

                new Robot
                {
                    Id = Guid.NewGuid(),
                    Name = "T0"
                },
                
                new Robot
                {
                    Id= Guid.NewGuid(),
                    Name= "T1"
                }
                );
        }
    }
}
