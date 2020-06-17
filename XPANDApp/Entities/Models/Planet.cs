using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Entities.Models
{
    [Table("Planet")]
    public class Planet
    {
        [Column("PlanetId")]
        [Key]
        [Required]
        public Guid ID { get; set; }

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
        [AllowNull]
        public Guid? DescriptionId { get; set; }
        public Description Description { get; set; }
    }
}
