using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class User
    {
        public int? UserId { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; }
        public int? Gg { get; set; }
    }
}
