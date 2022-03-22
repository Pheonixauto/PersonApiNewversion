using Microsoft.AspNetCore.Identity;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.AuthManager
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO loginUserDTO);
        Task<string> CreateToken();
        Task<IdentityResult> DeleteUser(string email, string password);

    }
}
