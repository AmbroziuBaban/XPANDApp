using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class DescriptionRobotDto
    {
        public Guid Id { get; set; }

        public Guid RobotId { get; set; }
        public Robot Robot { get; set; }
    }
}
