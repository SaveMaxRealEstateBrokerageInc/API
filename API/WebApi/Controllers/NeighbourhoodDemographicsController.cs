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
    /// <summary>
    /// controls Neighbourhood data for NeighbourhoodDemographicManager.
    /// </summary>
    public class NeighbourhoodDemographicsController : ApiController
    {


        /// <summary>
        /// get NeighbourhoodDemographicData of all cities.
        /// </summary> 
        /// <returns>object for fetching all</returns>
        public HttpResponseMessage Get()
        {
            var data = NeighbourhoodDemograpicManager.GetNeighbourhoodDemographics().ToList();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Data Found");
            }   
        }

        /// <summary>
        ///  get NeighbourhoodDemographicData by city(location Name)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>object for fetching particular city and valid response code for given request</returns>
        public HttpResponseMessage Get(string id)
        {  
            var data = NeighbourhoodDemograpicManager.GetNeighbourhoodDemographic(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record found for id " + id);
            }
        }

        /// <summary>
        ///  add NeighbourhoodDemographicData for new city
        /// </summary>
        /// <param name="data"></param>
        /// <returns>requested object if given city and id not exists
        /// otherwise conflict response will be returned
        /// </returns>
        public HttpResponseMessage Post([FromBody]NeighbourhoodDemographic data)
        {
            if (data != null)
            {
                try
                {
                    if(NeighbourhoodDemograpicManager.SearchNeighbourhoodDemographicByLocationId(data.LocationId)!=null)
                    {
                        ErrorViewModel error = new ErrorViewModel();
                        error.ErrorMessage = "Id Already Exists";
                        error.Links = "http://localhost:64401/Help/Api/POST-api-NeighbourhoodDemographics";
                        return Request.CreateResponse(HttpStatusCode.Conflict, error);
                    }
                    else if (NeighbourhoodDemograpicManager.SearchNeighbourhoodDemographicByLocationName(data.LocationName)!=null)
                    {
                        ErrorViewModel error = new ErrorViewModel();
                        error.ErrorMessage = "Location Already Exists";
                        error.Links = "http://localhost:64401/Help/Api/POST-api-NeighbourhoodDemographics";
                        return Request.CreateResponse(HttpStatusCode.Conflict, error);
                    }
                    else
                    {
                        NeighbourhoodDemograpicManager.PostNeighbourhoodDemographic(data);
                        var message = Request.CreateResponse(HttpStatusCode.Created, data);
                        message.Headers.Location = new Uri(Request.RequestUri + data.LocationId.ToString());
                        return message;
                    }
                    
                }
                catch (Exception ex)
                {
                    ErrorViewModel error = new ErrorViewModel();
                    error.ErrorMessage = ex.ToString();
                    error.Links = "http://localhost:64401/Help/Api/POST-api-NeighbourhoodDemographics";
                    return Request.CreateResponse(HttpStatusCode.BadRequest, error);
                }
            }
            else
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Object Found In Body";
                error.Links = "http://localhost:64401/Help/Api/POST-api-NeighbourhoodDemographics";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
    }
        /// <summary>
        ///  update NeighbourhoodDemographicData by locationName
        /// </summary>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <returns>updated object after checking id and requested object in body</returns>
        public HttpResponseMessage Put(string id, [FromBody]NeighbourhoodDemographic newData)
        {
            if (newData==null)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Object Found In Body";
                error.Links = "http://localhost:64401/Help/Api/PUT-api-NeighbourhoodDemographics-id";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else if(id == null)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Id Found In Url";
                error.Links = "http://localhost:64401/Help/Api/PUT-api-NeighbourhoodDemographics-id";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                try
                {
                    NeighbourhoodDemographic data = NeighbourhoodDemograpicManager.SearchNeighbourhoodDemographicByLocationName(id);
                    if (data != null)
                    {
                        NeighbourhoodDemographic updatedNeighbourhoodDemographic = NeighbourhoodDemograpicManager.PutNeighbourhoodDemographic(id, newData);
                        return Request.CreateResponse(HttpStatusCode.OK, updatedNeighbourhoodDemographic);
                    }
                    else
                    {
                        ErrorViewModel error = new ErrorViewModel();
                        error.ErrorMessage = "No Record Found For Given Details";
                        error.Links = "http://localhost:64401/Help/Api/PUT-api-NeighbourhoodDemographics-id";
                        return Request.CreateResponse(HttpStatusCode.NotFound, error);
                    }
                }
                catch (Exception ex)
                {
                    ErrorViewModel error = new ErrorViewModel();
                    error.ErrorMessage = ex.ToString();
                    error.Links = "http://localhost:64401/Help/Api/PUT-api-NeighbourhoodDemographics-id";
                    return Request.CreateResponse(HttpStatusCode.BadRequest, error);
                }
            }
        }
        /// <summary>
        ///  delete NeighbourhoodDemographicData by locationName
        ///  after checking either given city and id exists or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Delete(int id)
        {
            if(id == null)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.ErrorMessage = "No Id Found In Url";
                error.Links = "http://localhost:64401/Help/Api/DELETE-api-NeighbourhoodDemographics-id";
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
            else
            {
                try
                {
                    NeighbourhoodDemograpicManager.DeleteNeighbourhoodDemographic(id);
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }
                catch (NullReferenceException)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record found for given id " + id);
                }
                catch (Exception ex)
                {
                    ErrorViewModel error = new ErrorViewModel();
                    error.ErrorMessage = ex.ToString();
                    error.Links = "http://localhost:64401/Help/Api/DELETE-api-NeighbourhoodDemographics-id";
                    return Request.CreateResponse(HttpStatusCode.BadRequest, error);
                }
            }
        }

    }
}