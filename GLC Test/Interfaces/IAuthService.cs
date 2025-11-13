namespace GLCTest.Interfaces;

public interface IAuthService
{
    Task<bool> LoginAsync(string username, string password);
    Task LogoutAsync();
    bool IsAuthenticated { get; }
}
