using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    class UserInRelation
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public List<User> User1 { get; set; }
        public List<User> User2 { get; set; }
        public List<TypeOfRelation> TypeOfRelation { get; set; }       
    }
}
