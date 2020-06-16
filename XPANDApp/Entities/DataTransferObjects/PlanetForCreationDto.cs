using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class PlanetForCreationDto
    {

        [Column("PlanetName")]
        [Required]
        [MaxLength(30, ErrorMessage = "The name can't have more then 30 characters")]
        public string Name { get; set; }

        [Column("PlanetImage")]
        public Byte[] Image { get; set; }

        [Column("PlanetStatus")]
        [Required]
        [DefaultValue(0)]
        public Byte Status { get; set; }

        [Column("DescriptionId")]
        [ForeignKey(nameof(Description))]
        [System.Diagnostics.CodeAnalysis.AllowNull]
        public Guid? DescriptionId { get; set; }
    }
}
