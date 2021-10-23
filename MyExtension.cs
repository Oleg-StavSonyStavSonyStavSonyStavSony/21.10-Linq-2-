using System;
using System.Collections.Generic;
using System.Text;

namespace _21._10
{
    static class MyExtension
    {
        public static List<InfoUser> FindAll(this MySystem mysestem, InfoUser user)
        {
            List<InfoUser> infoUsers = new List<InfoUser>();
            foreach (var item in mysestem)
            {
                if (item.Pasword == user.Pasword && item.Login == user.Login)
                    infoUsers.Add(item);
            }
            return infoUsers;
        }
    }
}
