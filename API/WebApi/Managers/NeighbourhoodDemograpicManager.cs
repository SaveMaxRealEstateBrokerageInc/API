using WebApi.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Managers
{
    /// <summary>
    /// Manage data from saveMaxDataService
    /// </summary>
    public class NeighbourhoodDemograpicManager
    {
        /// <summary>
        /// get NeighbourhoodDemographicData of all cities.
        /// </summary> 
        /// <returns>object for fetching all</returns>
        public static IEnumerable<NeighbourhoodDemographic> GetNeighbourhoodDemographics()
        {
            return DataService.GetNeighbourhoodDemographics().ToList();
        }

        /// <summary>
        ///  get NeighbourhoodDemographicData by city(location Name)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>object for fetching particular city and valid response code for given request</returns>
        public static NeighbourhoodDemographic GetNeighbourhoodDemographic(string id)
        {
            var data = DataService.GetNeighbourhoodDemographics().Where(e => e.LocationName == id).SingleOrDefault();
            return data;

        }
        /// <summary>
        ///  add NeighbourhoodDemographicData for new city
        /// </summary>
        /// <param name="data"></param>
        /// <returns>requested object if given city and id not exists
        /// otherwise conflict response will be returned
        /// </returns>

        public static void PostNeighbourhoodDemographic(NeighbourhoodDemographic data)
        {
            DataService.PostNeighbourhoodDemographic(data);
        }
        /// <summary>
        ///  update NeighbourhoodDemographicData by locationName
        /// </summary>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <returns>updated object after checking id and requested object in body</returns>

        public static NeighbourhoodDemographic PutNeighbourhoodDemographic(string id, NeighbourhoodDemographic newData)
        {
            NeighbourhoodDemographic data = DataService.PutNeighbourhoodDemographic(id, newData);
            return data;

        }


        /// <summary>
        ///  delete NeighbourhoodDemographicData by locationName
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static void DeleteNeighbourhoodDemographic(int id)
        {
                DataService.DeleteNeighbourhoodData(id);        
        }
        /// <summary>
        ///  search NeighbourhoodDemographicData by locationName
        /// </summary>
        /// <param name="id"></param>
        /// <returns>searched object</returns>
        public static NeighbourhoodDemographic SearchNeighbourhoodDemographicByLocationName(string id)
        {
            return DataService.GetNeighbourhoodDemographics().Where(e => e.LocationName == id).SingleOrDefault();
        }

        /// <summary>
        ///  search NeighbourhoodDemographicData by locationId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>searched object</returns>
        public static NeighbourhoodDemographic SearchNeighbourhoodDemographicByLocationId(int id)
        {
            return DataService.GetNeighbourhoodDemographics().Where(e => e.LocationId == id).SingleOrDefault();
        }
    }
}