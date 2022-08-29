using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models.DataLayer
{
    [Table("albums")]
    public partial class Albums
    {
        public Albums()
        {
            Songs = new HashSet<Songs>();
        }

        [Key]
        [Column("album_id")]
        public int AlbumId { get; set; }
        [Required]
        [Column("album_name")]
        [StringLength(50)]
        public string AlbumName { get; set; }
        [Column("artist_id")]
        public int ArtistId { get; set; }
        [Required]
        [Column("record_label")]
        [StringLength(50)]
        public string RecordLabel { get; set; }
        [Required]
        [Column("genre")]
        [StringLength(20)]
        public string Genre { get; set; }
        [Column("release_date", TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
        [Column("notable_fact", TypeName = "text")]
        public string NotableFact { get; set; }

        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.Albums))]
        public virtual Artists Artist { get; set; }
        [InverseProperty("Album")]
        public virtual ICollection<Songs> Songs { get; set; }
    }
}
