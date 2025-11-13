using GLC.Shared.DTOs;

namespace GLCTest.Interfaces;

public interface IAuthService
{
    Task<bool> LoginAsync(LoginRequestDto request);
    Task LogoutAsync();
    bool IsAuthenticated { get; }
}
