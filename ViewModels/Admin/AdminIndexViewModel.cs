using DAL.Models;
using ForumProject.ViewModels.Role;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumProject.ViewModels.Account;

namespace ForumProject.ViewModels.Admin
{
    public class AdminIndexViewModel
    {
        public IEnumerable<RoleViewModel> Roles { get; set; }
        public IEnumerable<UserViewModel> Users { get; set; }
    }
}
