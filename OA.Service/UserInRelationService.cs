using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;
using OA.Repo;

namespace OA.Service
{
    public class UserInRelationService : IUserInRelationService
    {
        private IRepository<UserInRelation> userInRelationRepository;

        public UserInRelationService(IRepository<UserInRelation> userInRelationRepository)
        {
            this.userInRelationRepository = userInRelationRepository;
        }

        public void DeleteUserInRelation(long id)
        {
            UserInRelation userInRelation = userInRelationRepository.Get(id);
            userInRelationRepository.Remove(userInRelation);
            userInRelationRepository.SaveChanges();
            throw new NotImplementedException();
        }

        public IEnumerable<UserInRelation> GetUserInRelation()
        {
            return userInRelationRepository.GetAll();
            throw new NotImplementedException();
        }

        public UserInRelation GetUserInRelation(long id)
        {
            return userInRelationRepository.Get(id);
            throw new NotImplementedException();
        }

        public void InsertUserInRelation(UserInRelation userInRelation)
        {
            userInRelationRepository.Insert(userInRelation);
            throw new NotImplementedException();
        }

        public void UpdateUserInRelation(UserInRelation userInRelation)
        {
            userInRelationRepository.Update(userInRelation);
            throw new NotImplementedException();
        }
    }
}
