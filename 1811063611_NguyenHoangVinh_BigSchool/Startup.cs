using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811063611_NguyenHoangVinh_BigSchool.Startup))]
namespace _1811063611_NguyenHoangVinh_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
