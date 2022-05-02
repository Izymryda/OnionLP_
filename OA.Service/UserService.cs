using OA.Data;
using OA.Repo;
using System.Collections.Generic;

namespace OA.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<UserProfile> userProfileRepository; //все в одному через те, що це по факту одна сутність

        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public void DeleteUser(long id)
        {
            UserProfile userProfile = userProfileRepository.Get(id);
            userProfileRepository.Remove(userProfile);
            User user = GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
            throw new System.NotImplementedException();
        }

        public User GetUser(long id)
        {
            return userRepository.Get(id);
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
            throw new System.NotImplementedException();
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
            throw new System.NotImplementedException();
        }
    }
}
