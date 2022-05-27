using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class UserInRelation:BaseUserEntity
    {
        public List<UserProfile> User1 { get; set; }
        public List<UserProfile> User2 { get; set; }
        public List<TypeOfRelation> TypeRelBetweenUser { get; set; }       
    }
}
