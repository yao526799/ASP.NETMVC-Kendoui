﻿using System.Collections.Generic;

namespace Fzrain.Core.Domain.Permission
{
   public  class Role:BaseEntity 
    {
       public string RoleName { get; set; }
       public int Order { get; set; }

       public virtual ICollection<User> Users { get; set; }
       public virtual ICollection<Module> Modules { get; set; }
    }
}
