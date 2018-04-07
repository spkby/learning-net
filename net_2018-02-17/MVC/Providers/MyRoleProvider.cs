using MVC.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVC.Providers
{
    public class MyRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] roles = { "" };
            using (DBContent db = new DBContent())
            {
                var user = db.Users.Where(u => u.Name.Equals(username)).FirstOrDefault();
                if(user != null)
                { 
                    var role = db.Roles.Where(r => r.RoleId == user.RoleId).FirstOrDefault();
                    roles[0] = role.roleName;
                }
            }
            return roles;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            bool inRole = false;
            using (DBContent db = new DBContent())
            {
                var user = db.Users.Where(u => u.Name.Equals(username)).FirstOrDefault();
                if (user != null)
                {
                    var role = db.Roles.Where(r => r.RoleId == user.RoleId).FirstOrDefault();
                    if (role.roleName.Equals(roleName)) inRole = true;
                }
            }
            return inRole;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}