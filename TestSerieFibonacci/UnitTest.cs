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
        public void TestRango10()
        {
            int[] serie = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] serie2 = _serieService.GetSerie(10);

            for (int i = 0; i < serie.Length; i++)
            {
                Assert.AreEqual(serie[i], serie2[i]);
            }
        }
        [Test]
        public void TestCero()
        {
            int[] serie = _serieService.GetSerie(0);

            Assert.AreEqual(serie[0], 0);
            
        }
        [Test]
        public void TestCaracter()
        {
            Assert.That(() =>            
                _serieService.GetSerie(int.Parse("algo")),
                                Throws.Exception);
        }
        [Test]
        public void TestNull()
        {
            Assert.That(() =>
                _serieService.GetSerie(int.Parse(null)),
                                Throws.Exception);
        }
    }
}