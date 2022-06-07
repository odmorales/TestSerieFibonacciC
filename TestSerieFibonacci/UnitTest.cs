using NUnit.Framework;
using SerieService;

namespace TestSerieFibonacci
{
    public class Tests
    {
        Serie _serieService;

        [SetUp]
        public void Setup()
        {
            _serieService = new Serie();
        }

        [Test]
        public void Test1()
        {
            int[] serie = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] serie2 = _serieService.getSerie(10);

            for (int i = 0; i < serie.Length; i++)
            {
                Assert.AreEqual(serie[i], serie2[i]);
            }
        }
    }
}