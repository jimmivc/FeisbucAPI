using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeisbucAPI.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        private int id;
        [JsonProperty(PropertyName = "name")]
        private string name;
        [JsonProperty(PropertyName = "pass")]
        private string pass;
        [JsonProperty(PropertyName = "correo")]
        private string correo;
        [JsonProperty(PropertyName = "lastname")]
        private string lastname;
        [JsonProperty(PropertyName = "age")]
        private int age;

        public User(int pid, string pname,string ppass,string pcorreo, string plast, int page)
        {
            Id = pid;
            Name = pname;
            Pass = ppass;
            Correo = pcorreo;
            Lastname = plast;
            Age = page;
        }

        [JsonIgnore]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [JsonIgnore]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [JsonIgnore]
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        [JsonIgnore]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        [JsonIgnore]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        [JsonIgnore]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}