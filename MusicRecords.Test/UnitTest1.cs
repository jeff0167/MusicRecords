using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MusicRecords.Test
{
    [TestClass]
    public class UnitTest1
    {
        Managers.MusicRecordManager musicRecordManager;
        private static readonly int NextId = 0;
        static List<MusicRecord> MyMusicRecords = new List<MusicRecord>()
        {
            new MusicRecord(NextId++,"eminem","numb1",1070,1900),
            new MusicRecord(NextId++,"eminem2","numb2",1200,1901),
            new MusicRecord(NextId++,"eminem3","numb3",1004,1902),
            new MusicRecord(NextId++,"eminem4","numb4",105,1903),
        };
        [TestInitialize]
        public void Initialize()
        {
            musicRecordManager = new Managers.MusicRecordManager();
        }

        [TestMethod]
        public void TestShouldGetAllRecords()
        {
            List<MusicRecord> myMusic = (List<MusicRecord>)musicRecordManager.GetAll();

            CollectionAssert.AreEqual(MyMusicRecords,myMusic);
        }
    }
}
