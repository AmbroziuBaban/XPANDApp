using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class DescriptionRobotForCreationDto
    {
        public Guid DescriptionId { get; set; }
        public Guid RobotId { get; set; }
    }
}
