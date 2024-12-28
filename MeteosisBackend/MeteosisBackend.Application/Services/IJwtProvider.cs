using MeteosisBackend.Application.Features.Auth.Login;
using MeteosisBackend.Domain.Entities;

namespace MeteosisBackend.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
