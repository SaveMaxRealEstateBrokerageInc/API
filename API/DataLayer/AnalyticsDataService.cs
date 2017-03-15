using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AnalyticsDataService
    {
        public static List<UserAnalytic> GetUserData()
        {
            using (var db = new DataContext())
            {
                return db.UserAnalytics.ToList();
            }
        }

        public static UserAnalytic PutUserAnalytic(String id, UserAnalytic newData)
        {
            using (var db = new DataContext())
            {
                UserAnalytic oldData = GetUserData().Where(e => e.UserId == id).FirstOrDefault();
                oldData = newData;
                db.Entry(oldData).State = EntityState.Modified;
                db.SaveChanges();
                return oldData;
            }
        }

        public static void PostUserAnalytic(UserAnalytic userAnalytic)
        {
            using (var db = new DataContext())
            {
                db.UserAnalytics.Add(userAnalytic);
                db.SaveChanges();
            }
        }
        public static List<PropertyAnalytic> GetPropertyAnalytics()
        {
            using (var db = new DataContext())
            {
                var data = db.PropertyAnalytics.ToList();
                return data;
            }
        }
        public static void PostPropertyAnalytics(PropertyAnalytic propertyAnalytic)
        {
            using (var db = new DataContext())
            {
                db.PropertyAnalytics.Add(propertyAnalytic);
                db.SaveChanges();
            }
        }



    }
}
