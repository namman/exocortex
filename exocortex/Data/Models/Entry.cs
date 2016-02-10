using System;
using System.Collections.Generic;

namespace exocortex.Data.Models
{
    public class Entry
    {

        public int Id { get; set; }
        public DateTimeOffset? DateTime { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; } // HTML
        public ICollection<Recall> Recalls { get; set; }
        public ICollection<Presentation> Presentations { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}