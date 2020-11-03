namespace AllAboutBoxing.Data.Models
{
    public class Record
    {
        public int BoxerId { get; set; }

        public byte Wins { get; set; }

        public byte Loses { get; set; }

        public byte Draws { get; set; }

        public byte NoContests { get; set; }
    }
}
