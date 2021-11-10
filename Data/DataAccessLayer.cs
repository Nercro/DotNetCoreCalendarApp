using CalendarApop.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarApop.Data
{
	public class DataAccessLayer : IDataAccessLayer
	{
		private ApplicationDbContext db = new ApplicationDbContext();

		public void CreateCalendarEvent(IFormCollection form)
		{
			CalendarEvent newCalendarEvent = new CalendarEvent(form, db.Locations.FirstOrDefault(x => x.Name == form["Loacation"]));
			
			db.CalendarEvents.Add(newCalendarEvent);
			db.SaveChanges();
		}

		public void CreateLocation(Location location)
		{
			db.Locations.Add(location);
			db.SaveChanges();
		}

		public void DeleteCalendarEvent(int id)
		{
			var myEvent = db.CalendarEvents.FirstOrDefault(x => x.EventId == id);
			
			db.CalendarEvents.Remove(myEvent);
			db.SaveChanges();
		}

		public CalendarEvent GetCalendarEvent(int id)
		{
			return db.CalendarEvents.FirstOrDefault(x => x.EventId == id);
		}

		public List<CalendarEvent> GetCalendarEvents()
		{
			return db.CalendarEvents.ToList();
		}

		public Location GetLocation(int id)
		{
			return db.Locations.FirstOrDefault(x => x.Id == id);
		}

		public List<Location> GetLocations()
		{
			return db.Locations.ToList();
		}

		public List<CalendarEvent> GetMyCalendarEvents(string userId)
		{
			return db.CalendarEvents.Where(x => x.User.Id == userId).ToList();
		}

		public void UpdateCalendarEvent(IFormCollection form)
		{
			var myEvent = db.CalendarEvents.FirstOrDefault(x => x.EventId == int.Parse(form["Id"]));
			var location = db.Locations.FirstOrDefault(x => x.Name == form["Location"]);

			myEvent.UpdateCalendarEvent(form, location);

			db.Entry<CalendarEvent>(myEvent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			db.SaveChanges();
			
		}
	}
}
