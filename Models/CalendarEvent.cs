using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarApop.Models
{
	public class CalendarEvent
	{
		[Key]
		public int EventId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public bool IsFullDay { get; set; }

		public virtual Location Location {get; set;}
		public virtual ApplicationUser User { get; set; }


		public CalendarEvent()
		{

		}

		public CalendarEvent(IFormCollection form, Location location)
		{
			EventId = int.Parse(form["Id"]);
			Name = form["Name"];
			Description = form["Description"];
			StartTime = DateTime.Parse(form["StartTime"]);
			EndTime = DateTime.Parse(form["EndTime"]);
			IsFullDay = bool.Parse(form["IsFullDay"]);
			Location = location;

		}

		public void UpdateCalendarEvent(IFormCollection form, Location location)
		{
			EventId = int.Parse(form["Id"]);
			Name = form["Name"];
			Description = form["Description"];
			StartTime = DateTime.Parse(form["StartTime"]);
			EndTime = DateTime.Parse(form["EndTime"]);
			IsFullDay = bool.Parse(form["IsFullDay"]);
			Location = location;
		}

	}
}
