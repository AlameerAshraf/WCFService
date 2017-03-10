namespace Magic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("employee")]
    public partial class employee
    {
        
        [Key]
        [DataMember]
        public int empid { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string empname { get; set; }
        [DataMember]
        [Column(TypeName = "money")]
        public decimal empsalary { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string empAddress { get; set; }
        [DataMember]
        public int PId { get; set; }
        [DataMember]
        public virtual project project { get; set; }
    }
}
