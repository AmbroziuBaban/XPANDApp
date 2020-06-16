using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("Captain")]
    public class Captain
    {
        [Column("CaptainId")]
        [Key]
        public Guid Id { get; set; }

        [Column("CaptainName")]
        [Required]
        [MaxLength(50,ErrorMessage ="Captain name can't be longer then 50 characters")]
        public string Name { get; set; }
    }
}
