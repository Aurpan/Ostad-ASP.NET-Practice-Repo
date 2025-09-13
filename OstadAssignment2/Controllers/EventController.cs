using Microsoft.AspNetCore.Mvc;
using OstadAssignment2.Models;

namespace OstadAssignment2.Controllers
{
    public class EventController : Controller
    {
        public IActionResult GetAll()
        {
            ViewData["header"] = "All Events";
            return View("Index", new List<EventViewModel>());
        }

        public IActionResult GetUpcoming()
        {
            ViewData["header"] = "Upcoming Events";
            var allEvents = new List<EventViewModel>(); // fetched from database

            var upcomingEvents = new List<EventViewModel>();
            upcomingEvents.Add(new EventViewModel());

            foreach (var ev in allEvents)
            {
                //var currentDateTime = DateTime.Now;
                //var currentDate = currentDateTime.Date;
                //var nextDate = currentDate.AddDays(1);

                if (ev.Date >= DateTime.Now.Date.AddDays(1)) // any data after 14 Sept 12:00 AM
                {
                    upcomingEvents.Add(ev);
                }
            }

            //MyList<EventViewModel> test2 = new MyList<EventViewModel>();
            //test2.ReformList();

            // LINQ => Language Integrated Query
            upcomingEvents = allEvents
                .Where(e => e.Date >= DateTime.Now.Date.AddDays(1))
                .ToList();

            var filteredData = allEvents.Select(e => new { e.Name, e.Date }) // projection
                                       .Where(e => e.Date >= DateTime.Now.Date.AddDays(1)) // filtering
                                       //.OrderBy(e => e.Date) // sorting ascending
                                       .OrderByDescending(e => e.Date) // sorting Descending
                                       .ToList(); // materialization

            allEvents.GroupBy(e => e.AssignedUser) // grouping
                     .Select(g => new { User = g.Key, Events = g.ToList() }) // projection
                     .ToList(); // materialization

            // check for booking availability
            allEvents.Any(e => e.Date == DateTime.Now.Date);

            // check if all events meet the condition
            allEvents.All(e => e.Date >= DateTime.Now.Date.AddDays(-30));

            // return only the first matching event
            allEvents.Find(e => e.Date >= DateTime.Now.Date.AddDays(1));
            // alternatively
            var result = allEvents.FirstOrDefault(e => e.Date >= DateTime.Now.Date.AddDays(1));
            allEvents.First(e => e.Date >= DateTime.Now.Date.AddDays(1));


            IEnumerable<EventViewModel> res = from e in allEvents
                                              where e.Date >= DateTime.Now.Date.AddDays(1)
                                              select e;

            upcomingEvents = res.ToList();

            return View("Index", upcomingEvents);
        }
    }
}

// 3 layers 
// Presentation/View/UI Layer => where user interacts => Controllers + Views
// Business Logic Layer => where business logic is implemented => Services
// Data Access Layer => where data is accessed from database => Repositories
