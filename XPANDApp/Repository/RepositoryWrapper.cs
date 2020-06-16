using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IRobotRepository _robot;
        private ICaptainRepository _captain;
        private IDescriptionRepository _description;
        private IPlanetRepository _planet;

        public IRobotRepository Robot
        {
            get
            {
                if(_robot == null)
                {
                    _robot = new RobotRepository(_repoContext);
                }
                return _robot;
            }

        }

        public ICaptainRepository Captain
        {
            get
            {
                if(_captain == null)
                {
                    _captain = new CaptainRepository(_repoContext);
                }
                return _captain;
            }
        }

        public IDescriptionRepository Description
        {
            get
            {
                if (_description == null)
                {
                    _description = new DescriptionRepository(_repoContext);
                }
                return _description;
            }
        }

        public IPlanetRepository Planet
        {
            get
            {
                if(_planet == null)
                {
                    _planet = new PlanetRepository(_repoContext);
                }
                return _planet;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
