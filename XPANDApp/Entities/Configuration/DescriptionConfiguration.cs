using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class DescriptionConfiguration : IEntityTypeConfiguration<Description>
    {
        public void Configure(EntityTypeBuilder<Description> builder)
        {
            builder.HasData(
                new Description
                {

                },

                new Description
                {

                }
                );
        }
    }
}
