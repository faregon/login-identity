using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityMandatory2.Models
{
    public class RoleAdmin : IdentityRole
    {
        public RoleAdmin() : base() { }
        public RoleAdmin(string name) : base(name) { }
    }
}