using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class DataService
    {

        public IUserRepository repository;
        public ISender sender;

        public DataService()
        {
        }

        public DataService(IUserRepository repository, ISender sender)
        {
            this.repository = repository;
            this.sender = sender;
        }

        public void CreateUserAccount(string name, string email, string phoneNumber)
        {
            var user = new User
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber
            };
            
            repository.AddUser(user);

            sender.Send(user.Email, "Account was created");
        }

        public void DeleteUserAccount()
        {
            // repository.Delete
        }
    }
}
