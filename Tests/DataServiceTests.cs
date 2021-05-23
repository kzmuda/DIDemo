using Moq;
using NUnit.Framework;
using SuperApp;

namespace Tests
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            var repo = new Mock<IUserRepository>();
            var service = new DataService(repo.Object);
            service.CreateUserAccount("", "", "");
            repo.Verify(x => x.AddUser(It.IsAny<User>()), Times.Once);
        }
    }
}