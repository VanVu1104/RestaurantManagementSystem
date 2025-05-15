using Microsoft.AspNetCore.Identity;
using PizzaOrdering.ViewModels;

namespace PizzaOrdering.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterViewModel model);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();

    }
}
