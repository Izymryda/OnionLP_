using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repo;

namespace OA.Service
{
    class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(long id)
        {
            return userProfileRepository.Get(id);
            throw new NotImplementedException();
        }
    }
}
