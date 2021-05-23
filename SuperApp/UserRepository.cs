using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public interface IUserRepository
    {
        void AddUser(User user);
    }

    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            // Add user to DB
        }
    }
}
