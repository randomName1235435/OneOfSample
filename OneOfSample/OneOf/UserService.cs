using OneOf;
using SystemGeneric = System.Collections.Generic;

namespace OneOfSample.OneOf
{
    public class UserService : IUserService
    {
        private readonly SystemGeneric.HashSet<User> repository = new SystemGeneric.HashSet<User>();
        public OneOf<SuccesCode, ErrorCode> CreateUser(User user)
        {
            if (user == null)
            {
                return ErrorCode.invalid;
            }
            if (repository.Contains(user))
            {
                return ErrorCode.Duplicate;
            }
            repository.Add(user);
            return SuccesCode.Created;
        }
    }
}
