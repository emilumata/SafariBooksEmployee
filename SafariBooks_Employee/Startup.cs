using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafariBooks_Employee.Startup))]
namespace SafariBooks_Employee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
