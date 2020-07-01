using Auth0.OidcClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WinManager
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private async void OnLogin(object sender, EventArgs e)
        {
            var domain = ConfigurationManager.AppSettings["auth0.domain"].ToSecureString();
            var client = ConfigurationManager.AppSettings["auth0.client.id"].ToSecureString();
            var audience = ConfigurationManager.AppSettings["auth0.audience"].ToSecureString();

            var options = new Auth0ClientOptions
            {
                Domain = domain.ToUnsecureString(),
                ClientId = client.ToUnsecureString()
            };

            var auth0 = new Auth0Client(options);

            options.PostLogoutRedirectUri = options.RedirectUri;

            var param = new Dictionary<string, string>()
            {
                { "audience", audience.ToUnsecureString() }
            };

            Hide();

            var login = await auth0.LoginAsync(param);

            if (login.IsError)
            {
                Show();
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}