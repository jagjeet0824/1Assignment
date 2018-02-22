namespace _1Assignmnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cost { get; set; }

        [Required]
        [StringLength(10)]
        public string bike { get; set; }

        [Required]
        [StringLength(10)]
        public string cars { get; set; }

        [Required]
        [StringLength(10)]
        public string trains { get; set; }
    }
}
