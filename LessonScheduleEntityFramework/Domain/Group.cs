namespace LessonScheduleEntityFramework.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? Status { get; set; }
    }
}
