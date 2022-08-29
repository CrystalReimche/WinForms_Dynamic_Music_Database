namespace Final
{
    internal class AlbumSongList
    {
        public int Artist_ID { get; set; }
        public int Album_ID { get; set; }
        public int Song_ID { get; set; }
        public string Song_Name { get; set; }
        public string Writer_Name { get; set; }
        public int? Highest_Billboard_Ranking { get; set; }
        public int Length_In_Seconds { get; set; }
    }
}