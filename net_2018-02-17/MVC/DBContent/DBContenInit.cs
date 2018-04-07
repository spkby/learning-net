using MVC.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace MVC.DBContext
{
    public class DBContenUserInit : DropCreateDatabaseIfModelChanges<DBContent>
    {
        protected override void Seed(DBContent context)
        {
            var roles = new List<Role>
            {
                new Role{ RoleId = 1, roleName = "User"},
                new Role{ RoleId = 2, roleName = "Guest"},
                new Role{ RoleId = 3, roleName = "Admin"}
            };

            roles.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();

            var users = new List<User>
            {
                new User { UserID = 1, Name = "user 1", Password = "123456", PasswordCnfm = "123456", Email = "user1@com.com", RoleId = 1 },
                new User { UserID = 2, Name = "user 2", Password = "123456", PasswordCnfm = "123456", Email = "user2@com.com", RoleId = 1 },
                new User { UserID = 3, Name = "user 3", Password = "123456", PasswordCnfm = "123456", Email = "user3@com.com", RoleId = 1 },
                new User { UserID = 4, Name = "guest", Password = "123456", PasswordCnfm = "123456", Email = "guest@com.com", RoleId = 2 },
                new User { UserID = 5, Name = "admin", Password = "123456", PasswordCnfm = "123456", Email = "admin@com.com", RoleId = 3 }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();


            /*var messages = new List<Message>
            {
                new Message { MessageID=1, MessageText="тест1", UserId = 1},
                new Message { MessageID=2, MessageText="тест2", UserId = 2},
                new Message { MessageID=3, MessageText="тест3", UserId = 3},
                new Message { MessageID=4, MessageText="тест4", UserId = 1},
                new Message { MessageID=5, MessageText="тест5", UserId = 2},
                new Message { MessageID=6, MessageText="тест4", UserId = 3}
            };

            messages.ForEach(m => context.Messages.Add(m));
            context.SaveChanges();*/
            

        }
    }
}