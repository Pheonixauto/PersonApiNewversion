using PersonApi.ModelsDTO;

namespace PersonApi.Services.AuthManager
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO loginUserDTO);
        Task<string> CreateToken();
    }
}
