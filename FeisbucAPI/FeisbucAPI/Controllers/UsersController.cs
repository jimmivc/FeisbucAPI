using FeisbucAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FeisbucAPI.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public HttpResponseMessage Post([FromBody]string[] info)
        {
            User usuario = UsersManager.GetInstance().Login(info[0], info[1]);
            if(usuario!=null){
                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            }else{
                return Request.CreateResponse(HttpStatusCode.NotFound, usuario);
            }
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {

        }

        // POST: api/Users/save
        [Route("api/users/save")]
        [HttpPost]
        public HttpResponseMessage save([FromBody]string[] info)
        {
            User usuario = UsersManager.GetInstance().saveUserFeed(info[0],info[1],info[2]);
            if (usuario != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, usuario);
            }
        }



    }
}
