using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class UserProfile : BaseUserEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
    }
}
