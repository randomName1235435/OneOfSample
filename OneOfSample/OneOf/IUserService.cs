using OneOf;

namespace OneOfSample.OneOf
{
    public interface IUserService
    {
        OneOf<SuccesCode, ErrorCode> CreateUser(User user);
    }
}
