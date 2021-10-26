using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords.Managers
{
    public interface IMusicRecordManager
    {
        IEnumerable<MusicRecord> GetAll();

        MusicRecord Get(int id);

        MusicRecord Get(string title);

        bool Create(MusicRecord value);

        bool Delete(string title);

        bool Update(MusicRecord value);
    }
}
