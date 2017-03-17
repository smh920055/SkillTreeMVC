namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyEntities
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
    }
}
