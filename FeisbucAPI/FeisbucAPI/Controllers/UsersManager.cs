using FeisbucAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeisbucAPI.Controllers
{
    public class UsersManager
    {
        public class UsersManager
        {
            private static UsersManager instance;
            private List<User> userList;

            private UsersManager()
            {
                userList = new List<User>();
                userList.Add(new User(1, "bugs","bugs@warner.com","bbunny", "bunny", 79));
                userList.Add(new User(2, "lucas","lucas@warner.com","pduck", "duck", 30));
            }

            public static UsersManager GetInstance()
            {
                if (instance == null)
                    instance = new UsersManager();

                return instance;
            }

            public static void ClearInstance()
            {
                instance = new UsersManager();
            }

            public List<User> UserList
            {
                get { return userList; }
                set { userList = value; }
            }

            //public User Login(string username,string pass)
            //{
            //    User usuario = null;
            //    for (int i = 0; i < userList.Count; i++)
            //        if (userList[i].Name.Equals(username) && userList[i].Pass.Equals(pass))
            //            usuario = userList[i];

            //    return usuario;
            //}
        }
    }
}