using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class DescriptionForCreactionDto
    {


        [Column("DescriptionText")]
        public string Text { get; set; }

        [ForeignKey(nameof(Captain))]
        public Guid CaptainId { get; set; }

        public virtual IEnumerable<DescriptionRobotForCreationDto> DescriptionRobots { get; set; }
    }
}
