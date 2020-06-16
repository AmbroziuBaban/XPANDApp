using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class CaptainConfiguration : IEntityTypeConfiguration<Captain>
    {
        public void Configure(EntityTypeBuilder<Captain> builder)
        {
            builder.HasData(
                new Captain
                {
                    Id = new Guid("1eb841b5-e534-44cb-b678-3b515635bd41"),
                    Name= "Captain A"
                },
                new Captain
                {
                    Id = new Guid("396dcc34-f0e2-45ee-9842-b7671239248b"),
                    Name = "Captain B"
                }); ;
        }
    }
}
