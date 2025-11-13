using GLC.Shared.DTOs;
using GLCTest.Interfaces;

namespace GLCTest.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly CustomAuthenticationStateProvider _authStateProvider;

    public AuthService(IHttpClientFactory httpClientFactory, CustomAuthenticationStateProvider authStateProvider)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = new Uri("https://localhost:7136");
        _authStateProvider = authStateProvider;
    }

    public bool IsAuthenticated { get; private set; }

    public async Task<bool> LoginAsync(LoginRequestDto request)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/login", request);

            if (response.IsSuccessStatusCode)
            {
                IsAuthenticated = true;

                _authStateProvider.MarkUserAsAuthenticated(request.Username);

                return true;
            }

            IsAuthenticated = false;
            return false;
        }
        catch
        {
            IsAuthenticated = false;
            return false;
        }
    }

    public Task LogoutAsync()
    {
        IsAuthenticated = false;

        _authStateProvider.MarkUserAsLoggedOut();

        return Task.CompletedTask;
    }
}
