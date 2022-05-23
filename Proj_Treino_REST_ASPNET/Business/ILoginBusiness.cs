using Proj_Treino_REST_ASPNET.Data.VO;


namespace Proj_Treino_REST_ASPNET.Business {
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string userName);
    }
}