using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarSystem.Model {
  class Event {
    private DateTime Begin { get; set; }
    private DateTime End { get; set; }
    private string Description { get; set; }

    public Event(DateTime Begin, DateTime End, string Description) {
      this.Begin = Begin;
      this.End = End;
      this.Description = Description;
    }
  }
}