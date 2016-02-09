using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace exocortex.Data
{
    public class Request
    {
        public int Id { get; set; }
        public DateTimeOffset DateTime { get; set; }
        [ForeignKey("Entry")]
        public int EntryId { get; set; }
        public Entry Entry { get; set; }
    }
}