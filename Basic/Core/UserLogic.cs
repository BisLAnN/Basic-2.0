using Basic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Core
{
    public static class UserLogic
    {
        public static User FindUserByFirstName(List<User> users, string fullName)
            => users.FirstOrDefault(user => user.FullName == fullName);

        public static bool Validate(string login, string password) =>
            login == "bislan" && password == "1036";
    }
}
