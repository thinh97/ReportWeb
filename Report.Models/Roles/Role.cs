﻿using System.Collections.Generic;

namespace Report.Models.Roles
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Permission> Permissions { get; set; }
    }
}
