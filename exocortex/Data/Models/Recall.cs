using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exocortex.Data.Models
{
    public class Recall
    {
        public int Id { get; set; }

        public Entry Entry { get; set; }

        [ForeignKey("Entry")]
        public int EntryId { get; set; }
        public DateTimeOffset? DateTime { get; set; }

        [Range(1, 5)]
        public int SuccessLevel { get; set; }

    }
}