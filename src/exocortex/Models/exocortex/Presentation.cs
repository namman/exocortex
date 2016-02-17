using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace exocortex.Models.exocortex
{
    public class Presentation
    {
        public int Id { get; set; }
        public DateTimeOffset? DateTime { get; set; }
        public Entry Entry { get; set; }

        [ForeignKey("Entry")]
        public int EntryId { get; set; }
    }
}