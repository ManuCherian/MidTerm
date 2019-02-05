namespace Event.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event Details")]
    public partial class Event_Detail
    {
        public DateTime Starts { get; set; }

        public DateTime? Ends { get; set; }

        [Key]
        [Column("Id Number")]
        [StringLength(10)]
        public string Id_Number { get; set; }
    }
}
