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
        public static IEventDatabase Database { get; }

        static DatabaseFactory()
            {
                var db = new MemoryEventDatabase();

            ScheduledEvent e = new ScheduledEvent()
            {
                Name = "Mom Birthday Party",
                Description = "When my mom turns 30 for the 20th time",
                StartDate = new DateTime(2019, 10, 21, 9, 0,0),
                EndDate = new DateTime(2019, 10, 22, 9, 0,0),
                IsPublic = false
            };
            ScheduledEvent a = new ScheduledEvent()
            {
                Name = "Aunt Grace Birthday Party",
                Description = "Dinner at Mi Cocina",
                StartDate = new DateTime(2019, 7, 5, 3, 0, 0),
                EndDate = new DateTime(2019, 7, 6, 9, 0, 0),
                IsPublic = true
            };
            db.Add(e);
            db.Add(a);

            Database = db;
            }

    }
}