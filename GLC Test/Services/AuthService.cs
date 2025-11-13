using GLCTest.Interfaces;

namespace GLCTest.Services;

public class AuthService : IAuthService
{
    public bool IsAuthenticated { get; private set; }

    public async Task<bool> LoginAsync(string username, string password)
    {
        // Simple authentication logic - replace with real authentication
        if (username == "admin" && password == "password")
        {
            IsAuthenticated = true;
            return true;
        }

        // Simulate API call delay
        await Task.Delay(500);
        return false;
    }

    public Task LogoutAsync()
    {
        IsAuthenticated = false;
        return Task.CompletedTask;
    }
}

