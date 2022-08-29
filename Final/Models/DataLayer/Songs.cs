using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models.DataLayer
{
    [Table("songs")]
    public partial class Songs
    {
        [Key]
        [Column("song_id")]
        public int SongId { get; set; }
        [Required]
        [Column("song_name")]
        [StringLength(50)]
        public string SongName { get; set; }
        [Column("artist_id")]
        public int ArtistId { get; set; }
        [Column("album_id")]
        public int AlbumId { get; set; }
        [Column("length_in_seconds")]
        public int LengthInSeconds { get; set; }
        [Column("comments", TypeName = "text")]
        public string Comments { get; set; }
        [Column("highest_billboard_ranking")]
        public int? HighestBillboardRanking { get; set; }
        [Column("date_of_billboard_ranking")]
        public int? DateOfBillboardRanking { get; set; }
        [Required]
        [Column("writer_name")]
        [StringLength(500)]
        public string WriterName { get; set; }

        [ForeignKey(nameof(AlbumId))]
        [InverseProperty(nameof(Albums.Songs))]
        public virtual Albums Album { get; set; }
        [ForeignKey(nameof(ArtistId))]
        [InverseProperty(nameof(Artists.Songs))]
        public virtual Artists Artist { get; set; }
    }
}
