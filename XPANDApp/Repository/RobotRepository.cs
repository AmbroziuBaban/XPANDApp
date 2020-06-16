using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class RobotRepository : RepositoryBase<Robot>, IRobotRepository
    {
        public RobotRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IEnumerable<Robot> GetAllRobots()
        {
            return FindAll()
                .OrderBy(r => r.Name)
                .ToList();
        }

        public Robot GetRobotById(Guid robotId)
        {
            return FindByCondition(e => e.Id.Equals(robotId))
                .FirstOrDefault();
        }

        public void CreateRobot(Robot robot)
        {
            Create(robot);
        }

        public void UpdateRobot(Robot robot)
        {
            // TODO: optimize the update procedure
            Update(robot);
        }

        public void DeleteRobot(Robot robot)
        {
            Delete(robot);
        }
    }
}
