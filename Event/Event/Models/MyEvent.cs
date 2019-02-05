namespace Event.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyEvent")]
    public partial class MyEvent
    {
        [Key]
        [Column("Event id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Event_id { get; set; }

        [Column("Event Title")]
        [Required]
        [StringLength(50)]
        public string Event_Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
