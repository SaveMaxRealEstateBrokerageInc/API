using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLayer;
using WebApi.Models;
using WebApi.Managers;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/PropertyAnalytics
        

        public HttpResponseMessage Get(String id)
        {            
            if (id != null)
            {            
                AnalyticsManager.insertUserAnalytics(id);
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record found for id " + id);
            }

        }
        
        // POST: api/PropertyAnalytics
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PropertyAnalytics/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PropertyAnalytics/5
        public void Delete(int id)
        {
        }
    }
}
