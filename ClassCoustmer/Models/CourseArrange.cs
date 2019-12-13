namespace ClassCoustmer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseArrange")]
    public partial class CourseArrange
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(10)]
        public string ClassId { get; set; }

        [StringLength(10)]
        public string CourseSubjectId { get; set; }

        [StringLength(10)]
        public string TeacherId { get; set; }
    }
}
