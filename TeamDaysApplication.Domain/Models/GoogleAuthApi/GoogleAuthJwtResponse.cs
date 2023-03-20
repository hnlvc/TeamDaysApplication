using System.Text.Json.Serialization;

namespace TeamDaysApplication.Domain.Models.GoogleAuthApi;

public class GoogleAuthJwtResponse
{
    [JsonPropertyName("kind")] 
    public string Kind { get; set; } = string.Empty;

    [JsonPropertyName("localId")]
    public string LocalId { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("displayName")] 
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("idToken")] 
    public string IdToken { get; set; } = string.Empty;

    [JsonPropertyName("registered")] 
    public bool Registered { get; set; }

    [JsonPropertyName("refreshToken")] 
    public string RefreshToken { get; set; } = string.Empty;

    [JsonPropertyName("expiresIn")] 
    public int ExpiresIn { get; set; }
}