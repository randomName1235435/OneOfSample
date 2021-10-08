namespace OneOfSample.GenericStruct
{
    public interface IUserService
    {
        BetterResult<SuccesCode, ErrorCode> CreateUser(User user);
    }
}
