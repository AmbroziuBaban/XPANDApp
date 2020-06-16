using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRobotRepository : IRepositoryBase<Robot>
    {
        IEnumerable<Robot> GetAllRobots();
        Robot GetRobotById(Guid robotId);
        void CreateRobot(Robot robot);
        void UpdateRobot(Robot robot);
        void DeleteRobot(Robot robot);
    }
}
