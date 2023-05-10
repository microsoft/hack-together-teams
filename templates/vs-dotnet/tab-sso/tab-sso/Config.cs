using Microsoft.TeamsFx.Configuration;

namespace tab_sso
{
    public class ConfigOptions
    {
        public TeamsFxOptions TeamsFx { get; set; }
    }
    public class TeamsFxOptions
    {
        public AuthenticationOptions Authentication { get; set; }
    }
}
