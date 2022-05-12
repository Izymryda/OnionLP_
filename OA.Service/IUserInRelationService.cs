using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Service
{
    public interface IUserInRelationService
    {
        IEnumerable<UserInRelation> GetUserInRelation();
        UserInRelation GetUserInRelation(long id);
        void InsertUserInRelation(UserInRelation userInRelation);
        void UpdateUserInRelation(UserInRelation userInRelation);
        void DeleteUserInRelation(long id);
    }
}
