using GLC.Shared.DTOs;

namespace GLC.Application.Interfaces
{

    public interface IAuthService
    {
        Task<LoginResponseDto?> AuthenticateAsync(LoginRequestDto request);
    }
}
