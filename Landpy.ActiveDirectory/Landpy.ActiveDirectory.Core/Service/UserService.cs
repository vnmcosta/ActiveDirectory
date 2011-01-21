﻿using Landpy.ActiveDirectory.Object;
using System.Collections.Generic;
using System.DirectoryServices;
using System;
using Landpy.ActiveDirectory.Filter;

namespace Landpy.ActiveDirectory.Service
{
    public class UserService : ADObjectService<User>
    {
        public UserService(OperatorSecurity operatorSecurity)
            : base(operatorSecurity)
        {
            this.filter = new UserExpression();
        }
    }
}
