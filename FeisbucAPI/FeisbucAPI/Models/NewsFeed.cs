using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeisbucAPI.Models
{
    public class NewsFeed
    {
        private static int idNewsFeed = 0;
        private int id;
        private string mensaje;

        public NewsFeed(string pmensaje)
        {
            Mensaje = pmensaje;
            Id = ++idNewsFeed;
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}