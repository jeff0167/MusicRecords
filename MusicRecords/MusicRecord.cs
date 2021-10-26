using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords
{
    public class MusicRecord
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string  Artist { get; set; }
        public int Duration { get; set; }
        public int ReleaseYear { get; set; }

        public MusicRecord()
        {

        }

        public MusicRecord(int id, string title, string artist, int duration, int releaseYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            ReleaseYear = releaseYear;
        }

        public override bool Equals(object obj)
        {
            return obj is MusicRecord record &&
                   Id == record.Id &&
                   Title == record.Title &&
                   Artist == record.Artist &&
                   Duration == record.Duration &&
                   ReleaseYear == record.ReleaseYear;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Artist, Duration, ReleaseYear);
        }
    }
}
