using CalendarApop.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarApop.Data
{
	public interface IDataAccessLayer
	{
		public List<CalendarEvent> GetCalendarEvents();
		public List<CalendarEvent> GetMyCalendarEvents(string userId);
		public CalendarEvent GetCalendarEvent(int id);
		public void CreateCalendarEvent(IFormCollection form);
		public void UpdateCalendarEvent(IFormCollection form);
		public void DeleteCalendarEvent(int id);

		public List<Location> GetLocations();
		public Location GetLocation(int id);
		public void CreateLocation(Location location);

		
	}
}
