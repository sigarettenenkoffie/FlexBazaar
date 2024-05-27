using Duende.IdentityServer.Models;

namespace FlexBazaar.IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            { 
                new ApiScope(name: "flexbazaar_api", displayName: "FlexBazaar.API")
            };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            { 
                new Client
                {
                    ClientId = "web_client",

                    // no interactive user, use the clientid/secret for authentication
                    // TODO: what grantype best to use for this kind of application?
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("flexbazaarisawesome".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "flexbazaar_api" }
                }
            };
}