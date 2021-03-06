﻿using System;
using System.Collections.Generic;

namespace diploma.Models
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public IEnumerable<Result> Results { get; set; }
    }
}
