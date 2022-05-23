using Proj_Treino_REST_ASPNET.Data.VO;
using Proj_Treino_REST_ASPNET.Model;

namespace Proj_Treino_REST_ASPNET.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
