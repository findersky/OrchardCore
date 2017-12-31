using System;
using OrchardCore.Data.Migration;
using OrchardCore.OpenId.Indexes;

namespace OrchardCore.OpenId
{
    public class Migrations : DataMigration
    {
        public int Create()
        {
            SchemaBuilder.CreateMapIndexTable(nameof(OpenIdApplicationIndex), table => table
                .Column<string>(nameof(OpenIdApplicationIndex.ApplicationId), c => c.WithLength(48))
                .Column<string>(nameof(OpenIdApplicationIndex.ClientId))
                );

            SchemaBuilder.CreateReduceIndexTable(nameof(OpenIdApplicationByPostLogoutRedirectUriIndex), table => table
                .Column<string>(nameof(OpenIdApplicationByPostLogoutRedirectUriIndex.PostLogoutRedirectUri))
                .Column<int>(nameof(OpenIdApplicationByPostLogoutRedirectUriIndex.Count)));

            SchemaBuilder.CreateReduceIndexTable(nameof(OpenIdApplicationByRedirectUriIndex), table => table
                .Column<string>(nameof(OpenIdApplicationByRedirectUriIndex.RedirectUri))
                .Column<int>(nameof(OpenIdApplicationByPostLogoutRedirectUriIndex.Count)));

            SchemaBuilder.CreateReduceIndexTable(nameof(OpenIdApplicationByRoleNameIndex), table => table
                .Column<string>(nameof(OpenIdApplicationByRoleNameIndex.RoleName))
                .Column<int>(nameof(OpenIdApplicationByRoleNameIndex.Count)));

            SchemaBuilder.CreateMapIndexTable(nameof(OpenIdAuthorizationIndex), table => table
                .Column<string>(nameof(OpenIdAuthorizationIndex.AuthorizationId), c => c.WithLength(48))
                .Column<string>(nameof(OpenIdAuthorizationIndex.ApplicationId), c => c.WithLength(48))
                .Column<string>(nameof(OpenIdAuthorizationIndex.Status))
                .Column<string>(nameof(OpenIdAuthorizationIndex.Subject))
                .Column<string>(nameof(OpenIdAuthorizationIndex.Type))
                );

            SchemaBuilder.CreateMapIndexTable(nameof(OpenIdTokenIndex), table => table
                .Column<string>(nameof(OpenIdTokenIndex.TokenId), c => c.WithLength(48))
                .Column<string>(nameof(OpenIdTokenIndex.ApplicationId), c => c.WithLength(48))
                .Column<string>(nameof(OpenIdTokenIndex.AuthorizationId), c => c.WithLength(48))
                .Column<DateTimeOffset>(nameof(OpenIdTokenIndex.ExpirationDate))
                .Column<string>(nameof(OpenIdTokenIndex.ReferenceId))
                .Column<string>(nameof(OpenIdTokenIndex.Status))
                .Column<string>(nameof(OpenIdTokenIndex.Subject)));

            return 1;
        }
    }
}