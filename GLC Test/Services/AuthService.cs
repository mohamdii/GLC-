using GLC.Shared.DTOs;
using GLCTest.Interfaces;

namespace GLCTest.Services;

public class AuthService : IAuthService
{
    public bool IsAuthenticated { get; private set; }
    private readonly HttpClient _httpClient;
    public AuthService(IHttpClientFactory httpClient)
    {
        _httpClient = httpClient.CreateClient();
        _httpClient.BaseAddress = new Uri("https://localhost:7136");
    }
    public async Task<bool> LoginAsync(LoginRequestDto request)
    {
        var loginEndpoint = "api/login";

        var loginRequest = _httpClient.PostAsJsonAsync(loginEndpoint, request);

        if (loginRequest.Result.IsSuccessStatusCode)
        {
            IsAuthenticated = true;
            return true;
        }
        else
        {
            IsAuthenticated = false;
            return false;
        }
    }

    public Task LogoutAsync()
    {
        IsAuthenticated = false;
        return Task.CompletedTask;
    }
}

