﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SecurityMandatory2.Models
{

    public class CreateModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class LoginModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class RoleEditModel
    {
        public AppRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }

    }
    public class RoleModificationModel
    {
        [Required]
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}
