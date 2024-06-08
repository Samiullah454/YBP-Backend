using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Extensions;

namespace HCA.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }

        public static User CreateTenantAdminUserwithpassword(int tenantId, string emailAddress, string password, string mobile)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Password = password,

                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }

        public string PhoneNumber { get; set; }

        public string WhatsappNumber { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Profession { get; set; }

        public string ExactLocation { get; set; }

        public string Address { get; set; }

        public string CNIC { get; set; }

        public string ReferralCode { get; set; }

        public string ReferredBy { get; set; }

        public string Status { get; set; } = "Pending";

        public string Level { get; set; } = "Stranger";

        public decimal Balance { get; set; } = 0;
    }
}