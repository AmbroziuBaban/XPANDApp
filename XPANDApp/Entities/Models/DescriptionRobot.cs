using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("DescriptionRobot")]
    public class DescriptionRobot
    {
        [Column("DescriptionRobotId")]
        [Key]
        public Guid Id { get; set; } 

        [ForeignKey(nameof(Description))]
        public Guid DescriptionId { get; set; }
        public virtual Description Description { get; set; }

        [ForeignKey(nameof(Robot))]
        public Guid RobotId { get; set; }
        public virtual Robot Robot { get; set; }
    }
}
