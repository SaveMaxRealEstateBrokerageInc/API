using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using DataLayer;
using WebApi.Models;
using WebApi.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace WebApi.Controllers
{
    /// <summary>
    /// This controller is for dealing with Properties
    /// </summary>
    public class PropertiesController : ApiController
    {
        public static JsonSerializerSettings Settings
        {
            get
            {
                if (_Settings == null)
                {
                    _Settings = new JsonSerializerSettings();
                    _Settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                }
                return _Settings;
            }
        }
        private static JsonSerializerSettings _Settings;

        /// <summary>
        /// Use this method for fetching all properties
        /// This method will return List of properties and HttpResponse
        /// </summary> 
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage Get()
        {
            var data = PropertyManager.GetProperties().ToList();
            var result = JsonConvert.SerializeObject(data, Settings);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Data Found");
            }
        }

        /// <summary>
        /// use this method for getting particular property
        /// </summary>
        /// <param name="id"></param>
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage Get(int id)
        {
            PropertyAPIModel property = PropertyManager.GetProperty(id);
            if (property != null)
            {
                string userId = User.Identity.GetUserId();
                AnalyticsManager.PostPropertyAnalytics(id, userId);
                return Request.CreateResponse(HttpStatusCode.OK, property);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record found for id " + id.ToString());
            }

        }

        /// <summary>
        /// use this method for making post of property
        /// </summary>
        /// <param name="property"></param>
        /// <return>HttpResponseMessage</return>
        public HttpResponseMessage Post([FromBody]PropertyDetail property)
        {
            if (property != null)
            {
                try
                {
                    if(!PropertyManager.SearchProperty(property.ID).Equals(null))
                    {
                        ErrorViewModel error = new ErrorViewModel();
                        error.ErrorMessage = "Record Already Exists For Given Id";
                        error.Links = "http://localhost:64401/Help/Api/POST-api-Properties";
                        return Request.CreateResponse(HttpStatusCode.Conflict, error);
                    }
                    else
                    {
                        PropertyManager.PostProperty(property);
                        var message = Request.CreateResponse(HttpStatusCode.Created, property);
                        message.Headers.Location = new Uri(Request.RequestUri + property.PropertyID.ToString());
                        return message;
                    }
                }
                catch (Exception ex)
                {
                    ErrorViewModel error = new ErrorViewModel();
                    error.ErrorMessage = ex.ToString();
                    error.Links = "http://localhost:64401/Help/Api/POST-api-Properties";
                    return Request.CreateResponse(HttpStatusCode.BadRequest, error);
                }
            }
            else
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Object Found In Body";
                error.Links = "http://localhost:64401/Help/Api/POST-api-Properties";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
        }

        /// <summary>
        /// use this method for making put of property
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newProperty"></param>
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage Put(int id, [FromBody]PropertyDetail newProperty)
        {
            if(id.Equals(null))
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Id Found In Url";
                error.Links = "http://localhost:64401/Help/Api/PUT-api-Properties-id";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else if(newProperty.Equals(null))
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Object Found In Body";
                error.Links = "http://localhost:64401/Help/Api/PUT-api-Properties-id";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                try
                {
                    if(!PropertyManager.SearchProperty(id).Equals(null))
                    {
                        PropertyDetail updatedProperty = PropertyManager.PutProperty(id, newProperty);
                        return Request.CreateResponse(HttpStatusCode.OK, updatedProperty);
                    }
                    else
                    {
                        ErrorViewModel error = new ErrorViewModel();
                        error.ErrorMessage = "No Record Found For Given Id";
                        error.Links = "http://localhost:64401/Help/Api/PUT-api-Properties-id";
                        return Request.CreateResponse(HttpStatusCode.NotFound, error);
                    }                  
                }
                catch (Exception ex)
                {
                    ErrorViewModel error = new ErrorViewModel();
                    error.ErrorMessage = ex.ToString();
                    error.Links = "http://localhost:64401/Help/Api/PUT-api-Properties-id";
                    return Request.CreateResponse(HttpStatusCode.BadRequest, error);
                }
            }
        }

        /// <summary>
        /// use this method for making Delete of property
        /// </summary>
        /// <param name="id"></param>
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage Delete(int id)
        {
            if(id.Equals(null))
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Id Found In Url";
                error.Links = "http://localhost:64401/Help/Api/DELETE-api-Properties-id";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                try
                {
                    PropertyManager.DeleteProperty(id);
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }
                catch (NullReferenceException)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Record Found For Id " + id.ToString());
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
        }
    }
}
