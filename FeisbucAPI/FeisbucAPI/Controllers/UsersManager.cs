using FeisbucAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeisbucAPI.Controllers
{
    public class UsersManager
    {
        private static UsersManager instance;
        private List<User> userList;

        private UsersManager()
        {
            userList = new List<User>();
            userList.Add(new User(1, "bugs", "bbunny", "bugs@warner.com", "bunny", 79, new NewsFeed[4] { new NewsFeed("hola"), new NewsFeed("bugs"), new NewsFeed("bunn"), new NewsFeed("y") }));
            userList.Add(new User(2, "lucas","pduck","lucas@warner.com", "duck", 30, new NewsFeed[4] { new NewsFeed("aqui chilling"), new NewsFeed("hoy no es un buen dia"), new NewsFeed("cuack"), new NewsFeed("lol") }));
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

        public User Login(string username, string pass)
        {
            User usuario = null;
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name.Equals(username) && userList[i].Pass.Equals(pass))
                    usuario = userList[i];
            }

            return usuario;
        }
    }
}