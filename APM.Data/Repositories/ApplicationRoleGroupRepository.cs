﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APM.Data.Infrastructure;
using APM.Entity.Models;

namespace APM.Data.Repositories
{
    public interface IRoleGroupRepository : IRepository<RoleGroup>
    {

    }
    public class RoleGroupRepository : RepositoryBase<RoleGroup>, IRoleGroupRepository
    {
        public RoleGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
