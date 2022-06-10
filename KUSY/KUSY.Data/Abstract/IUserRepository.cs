﻿using KUSY.Entities.Concrete;
using KUSY.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Data.Abstract
{
    public interface IUserRepository: IEntityRepository<User>
    {
    }
}
