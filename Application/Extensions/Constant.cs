using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class Constant
    {
        public const string BrowserStorageKey = "x-key";
        public const string HttpClientName = "WebUIClient";
        public const string HttpClientHeaderScheme = "Bearer";
        public const string AuthenticationType = "JwtAuth";
        // Account Route
        public const string RegisterRoute = "api/account/identity/create";
        public const string LoginRoute = "api/account/identity/login";
        public const string ChangePasswordRoute = "api/account/identity/change-password";
        public const string DeleteRoute = "api/account/identity/delete";
        public const string RefreshTokenRoute = "api/account/identity/refresh-Token";
        public const string GetRolesRoute = "api/account/identity/role/list";
        public const string CreateRoleRoute = "api/account/identity/role/create";
        public const string CreateAdminRoute = "setting";
        public const string GetUserWithRolesRoute = "api/account/identity/user-with-roles";
        public const string ChangeUserRoleRoute = "api/account/identity/change-role";

        public static class Role
        {
            public static string Admin = "Admin";
            public static string User = "User";
        }
    }
}
