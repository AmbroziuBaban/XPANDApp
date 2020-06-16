using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RobotForCreationDto
    {
        [Column("RobotName")]
        [Required]
        [MaxLength(40, ErrorMessage = "Robot name can't be longer then 40 characters")]
        public string Name { get; set; }
    }
}
