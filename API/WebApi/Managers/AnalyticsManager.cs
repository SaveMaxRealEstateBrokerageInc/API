using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer;


namespace WebApi.Managers
{
    public class AnalyticsManager
    {



         public static void PostPropertyAnalytics(int ID, String userId)
        {
            List<PropertyAnalytic> propertyAnalytics = AnalyticsDataService.GetPropertyAnalytics();
            if (propertyAnalytics != null)
            {
                PropertyAnalytic data = propertyAnalytics.Where(x => x.ID == ID && x.UserId == userId).FirstOrDefault();
                if (data == null)
                {
                    PropertyAnalytic propertyAnalytic = new PropertyAnalytic();
                    propertyAnalytic.UserId = userId;
                    propertyAnalytic.ID = ID;
                    propertyAnalytic.DateCreated = DateTime.Now;
                    AnalyticsDataService.PostPropertyAnalytics(propertyAnalytic);
                }
            }
            else
            {
                PropertyAnalytic propertyAnalytic = new PropertyAnalytic();
                propertyAnalytic.UserId = userId;
                propertyAnalytic.ID = ID;
                propertyAnalytic.DateCreated = DateTime.Now;
                AnalyticsDataService.PostPropertyAnalytics(propertyAnalytic);
            }
        }

        public static void insertUserAnalytics(String id)
        {
            DateTime date = DateTime.Now;
           
            //UserAnalytic userAnalytic = null;
            //List<UserAnalytic> userAnalytic = AnalyticsDataService.GetUserData();         
            var userData = AnalyticsDataService.GetUserData().Where(e => e.UserId == id && e.LastUpdated == date).SingleOrDefault();
            if (userData != null)
            {
                var numOfVisits = userData.NumberOfVisits;
                UserAnalytic userAnalytic = new UserAnalytic();
                userAnalytic.UserId = id;
                userAnalytic.AnalyticsId = userData.AnalyticsId;
                //userAnalytic.loggedInTime = ;
                //userAnalytic.NumberOfVisits =
                userAnalytic.NumberOfVisits += numOfVisits;
                userAnalytic.LoginTime = userData.LoginTime;
                userAnalytic.LastUpdated = DateTime.Now;
                AnalyticsDataService.PutUserAnalytic(id, userAnalytic);
            }
            var userData1 = AnalyticsDataService.GetUserData().Where(e => e.UserId == id && e.LastUpdated != date).SingleOrDefault();
            if (userData1 != null)
            {
                UserAnalytic userAnalytic = new UserAnalytic();
                userAnalytic.UserId = id;             
                userAnalytic.NumberOfVisits = 1;
                userAnalytic.LoginTime = DateTime.Now;
                userAnalytic.LastUpdated = DateTime.Now;
                AnalyticsDataService.PostUserAnalytic(userAnalytic);
            }
            var userData2 = AnalyticsDataService.GetUserData().Where(e => e.UserId != id && e.LastUpdated != date).SingleOrDefault();
            if (userData2 != null)
            {
                UserAnalytic userAnalytic = new UserAnalytic();
                userAnalytic.UserId = id;               
                userAnalytic.NumberOfVisits = 1;
                userAnalytic.LoginTime = DateTime.Now;
                userAnalytic.LastUpdated = DateTime.Now;
                AnalyticsDataService.PostUserAnalytic(userAnalytic);
            }
        }

    }
}