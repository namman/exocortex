using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exocortex.Data
{
    public class Recall
    {
        public int Id { get; set; }

        public Entry Entry { get; set; }

        [ForeignKey("Entry")]
        public int EntryId { get; set; }

        [Range(1, 3)]
        public int SuccessLevel { get; set; }

    }
}