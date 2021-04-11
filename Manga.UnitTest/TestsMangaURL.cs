using NUnit.Framework;
using MangaSeries.Common;

namespace Manga.UnitTest
{
    public class TestsMangaURL
    {
        private const string URL = "https://readonepiece.in/manga/one-piece-chapter-1010/";
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestGetGetWebContent()
        {
            MangaURL mangaURL = new MangaURL(URL);
            string webResult  = mangaURL.GetWebContent();
            
            Assert.IsTrue(webResult != null || webResult?.Length != 0);
        }


    }
}