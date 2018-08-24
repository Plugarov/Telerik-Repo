using Academy.Models.Abstractions;

namespace Academy.Tests.Models.Abstractions.Mock
{
    class UserMock : User
    {
        public UserMock(string username) 
            : base(username)
        {
        }
    }
}
