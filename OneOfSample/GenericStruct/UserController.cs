using System.Net;

namespace OneOfSample.GenericStruct
{
    public class UserController : IController<User>
    {
        public ApiResult CreateUser(User toCreate)
        {
            return new UserService().CreateUser(toCreate).Match(OnSucces, OnFailed);
        }

        private ApiResult OnSucces(SuccesCode successCode) => new ApiResult(HttpStatusCode.OK);

        private ApiResult OnFailed(ErrorCode errorCode) => new ApiResult(HttpStatusCode.BadRequest);
    }
}
