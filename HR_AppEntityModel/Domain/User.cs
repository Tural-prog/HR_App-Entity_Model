namespace HR_AppEntityModel.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public byte[] Password { get; set; }

        public int? PersonnelId { get; set; }

        public virtual Personnel Personnel { get; set; }
    }
}
