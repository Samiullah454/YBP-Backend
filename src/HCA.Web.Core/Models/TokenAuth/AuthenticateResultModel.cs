using System.Collections.Generic;

namespace HCA.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public long UserId { get; set; }

        public string TenantId { get; set; }

        public List<string> Roles { get; set; }

        public List<string> Permissions { get; set; }
    }
}
