using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class UserInRelation:BaseUserEntity
    {
        public List<User> User1 { get; set; }
        public List<User> User2 { get; set; }
        public List<TypeOfRelation> TypeOfRelation { get; set; }       
    }
}
