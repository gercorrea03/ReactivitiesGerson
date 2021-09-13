using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Actividad 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Actividad realizada hace dos meses",
                    Category = "Software 4",
                    City = "Medellin",
                    Venue = "TdeA"
                },
                new Activity
                {
                    Title = "Actividad 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Actividad realizada hace un mes",
                    Category = "Software 4",
                    City = "Medellin",
                    Venue = "TdeA"
                },
                new Activity
                {
                    Title = "Actividad 3",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Actividad para realizar un mes",
                    Category = "Software 4",
                    City = "Medellin",
                    Venue = "TdeA"
                },
                new Activity
                {
                    Title = "Actividad 4",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Actividad para realizar dos meses",
                    Category = "Software 4",
                    City = "Medellin",
                    Venue = "TdeA"
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();

        }
    }
}