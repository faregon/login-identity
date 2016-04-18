using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using SecurityMandatory2.Models;

namespace SecurityMandatory2.Infrastructure
{
    public class RoleAdminManager : RoleManager<RoleAdmin>, IDisposable
    {
        public RoleAdminManager(RoleStore<RoleAdmin> store) : base(store) { }
        public static RoleAdminManager Create(
            IdentityFactoryOptions<RoleAdminManager> options,
            IOwinContext context)
        { return new RoleAdminManager(new RoleStore<RoleAdmin>(context.Get<AppIdentityDbContext>())); }
    }
}