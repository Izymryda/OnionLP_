using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class User : BaseUserEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}
