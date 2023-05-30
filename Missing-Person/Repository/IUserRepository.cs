﻿using Missing_Person.Models;

namespace Missing_Person.Repository
{
    public interface IUserRepository
    {
        public List<User> GetAllUser();
        public User GetUserById(string id);
    }
}
