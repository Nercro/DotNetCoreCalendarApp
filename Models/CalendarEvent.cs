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

	}
}
