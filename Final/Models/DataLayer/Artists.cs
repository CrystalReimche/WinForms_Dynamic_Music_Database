using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models.DataLayer
{
    [Table("artists")]
    public partial class Artists
    {
        public Artists()
        {
            Albums = new HashSet<Albums>();
            Songs = new HashSet<Songs>();
        }

        [Key]
        [Column("artist_id")]
        public int ArtistId { get; set; }
        [Column("stage_name")]
        [StringLength(50)]
        public string StageName { get; set; }
        [Required]
        [Column("birth_name")]
        [StringLength(50)]
        public string BirthName { get; set; }
        [Column("date_of_birth", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Column("hometown")]
        [StringLength(50)]
        public string Hometown { get; set; }
        [Column("date_of_death", TypeName = "date")]
        public DateTime? DateOfDeath { get; set; }
        [Required]
        [Column("fun_fact", TypeName = "text")]
        public string FunFact { get; set; }

        [InverseProperty("Artist")]
        public virtual ICollection<Albums> Albums { get; set; }
        [InverseProperty("Artist")]
        public virtual ICollection<Songs> Songs { get; set; }
    }
}
