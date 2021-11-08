using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarApop.Models
{
	public class Location
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<CalendarEvent> CalendarEvents { get; set; }

	}
}
