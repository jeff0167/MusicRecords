using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords.Managers
{
    public class MusicRecordManager : IMusicRecordManager
    {
        private static readonly int NextId = 0;

        static List<MusicRecord> MyMusicRecords = new List<MusicRecord>()
        {
            new MusicRecord(NextId++,"eminem","numb1",1070,1900),
            new MusicRecord(NextId++,"eminem2","numb2",1200,1901),
            new MusicRecord(NextId++,"eminem3","numb3",1004,1902),
            new MusicRecord(NextId++,"eminem4","numb4",105,1903),
        };
        public bool Create(MusicRecord value)
        {
            MyMusicRecords.Add(value);
            return true;
        }

        public bool Delete(string title)
        {
            MyMusicRecords.Remove(Get(title));
            return true;
        }

        public MusicRecord Get(string title)
        {
            return MyMusicRecords.Find(x => x.Title == title);
        }

        public MusicRecord Get(int id)
        {
             return MyMusicRecords.Find(x => x.Id == id);
        }

        public IEnumerable<MusicRecord> GetAll()
        {
            return MyMusicRecords;
        }

        public bool Update(MusicRecord value)
        {
            var v = Get(value.Title);
            v.Title = value.Title;
            return true;
        }
    }
}
