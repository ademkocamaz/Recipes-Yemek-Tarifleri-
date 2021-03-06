﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.Entities;

namespace YemekTarifleri.Entities.Concrete
{
    public class Role:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }

        public Role()
        {
            UserRoles=new List<UserRole>();
        }
    }
}
