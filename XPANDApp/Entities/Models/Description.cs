using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Entities.Models
{
    [Table("Description")]
    public class Description
    {
        [Column("DescriptionId")]
        [Key]
        [Required]
        public Guid Id { get; set; }
        
        [Column("DescriptionText")]
        public string Text { get; set; }

        [ForeignKey(nameof(Captain))]
        public Guid CaptainId { get; set; }
        public Captain Captain { get; set; }

        public virtual IEnumerable<DescriptionRobot> DescriptionRobots { get; set; }
        
    }
}
