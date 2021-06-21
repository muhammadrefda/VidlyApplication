using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyApplication.Startup))]
namespace VidlyApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        //public void ConfigureServices(IServiceCollection service)
        //{
        //    var mappingConfig = new MapperConfiguration(mappingConfig =>
        //    {
        //        mappingConfig.AddProfile(new MappingProfile());
        //    });
        //}
    }
}
