using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesFashion.Models.Dto
{
    public class AuthRq
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("id_type")]
        public string IdType { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
    public class AuthRs
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user_guid")]
        public string UserGuid { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("token")]
        public TokenRs Token { get; set; }
    }
    public class TokenRq
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
    public class TokenRefreshRq
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
    public class TokenRs
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_at")]
        public double ExpiresAt { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}