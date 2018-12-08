/*
 * Marissa Greise
 * ITSE 1430 
 * 12/5/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventPlanner.Memory;

namespace EventPlanner.Mvc.App_Start
{
    public class DatabaseFactory
    {
            //Normal instance methods go here...

            //Singleton pattern exposes the one instance using a static field/property
            public static DatabaseFactory Instance { get; } = CreateInstance();

            private static DatabaseFactory CreateInstance()
            {
                var db = new DatabaseFactory();           

                return db;
            }

           private static IEventDatabase _eventDatabase;

        //    static DatabaseFactory()
        //    {
        //        _eventDatabase = new MemoryEventDatabase();

        //        ScheduledEvent e = new ScheduledEvent()
        //        {
        //            Name = "Mom Birthday Party",
        //            Description = "When my mom turns 30 for the 20th time",
        //            StartDate = new DateTime(2018, 10, 1, 9, 2, 2),
        //            EndDate = new DateTime(2018, 10, 1, 9, 2, 2),
        //            IsPublic = false
        //        };
        //        ScheduledEvent a = new ScheduledEvent()
        //        {
        //            Name = "Aunt Grace Birthday Party",
        //            Description = "Dinner at Mi Cocina",
        //            StartDate = new DateTime(2019, 10, 1, 9, 2, 2),
        //            EndDate = new DateTime(2018, 10, 1, 9, 2, 2),
        //            IsPublic = true
        //         };
        //        _eventDatabase.Add(e);
        //        _eventDatabase.Add(a);
        //    }

        //    public static IEventDatabase GetDatabase()
        //    {
        //        return _eventDatabase;
        //    }

        //    public  static IEnumerable<ScheduledEvent> GetEvents()
        //    {
        //        EventCriteria eventCriteria = default(EventCriteria);
        //        eventCriteria.IncludePrivate = true;
        //        eventCriteria.IncludePublic = false;
        //        return _eventDatabase.GetAll(eventCriteria);
        //    }
    }
}