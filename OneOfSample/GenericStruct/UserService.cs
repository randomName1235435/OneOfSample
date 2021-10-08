using SystemGeneric = System.Collections.Generic;

namespace OneOfSample.GenericStruct
{
    public class UserService : IUserService
    {
        private static readonly SystemGeneric.HashSet<User> repository = new SystemGeneric.HashSet<User>();
        public BetterResult<SuccesCode, ErrorCode> CreateUser(User user)
        {
            if (user == null)
            {
                return new BetterResult<SuccesCode, ErrorCode>(ErrorCode.invalid);
            }
            if (repository.Contains(user))
            {
                return new BetterResult<SuccesCode, ErrorCode>(ErrorCode.Duplicate);
            }
            repository.Add(user);
            return new BetterResult<SuccesCode, ErrorCode>(SuccesCode.Created);
        }
    }
}
