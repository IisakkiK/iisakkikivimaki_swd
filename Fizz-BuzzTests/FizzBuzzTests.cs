using Fizz_Buzz;
using NUnit.Framework;

namespace Fizz_BuzzTests
{
    public class FizzbuzzTests
    {
        FizzBuzz fizzBuzz = null;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void LuodaanFizzBuzzLuokka()
        {
            Assert.IsInstanceOf<FizzBuzz>(fizzBuzz);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuYksi()
        {
            string vastaus = FizzBuzz.Luku(1);

            Assert.AreEqual("1", vastaus);
        }
        [Test]
        public void TulostaLukuKunSyotteenaAnnettuKaksi()
        {
            string vastaus = FizzBuzz.Luku(2);

            Assert.AreEqual("2", vastaus);
        }


        [Test]
        public void TulostaFizzJosLukuOnKolmellaJaollinen()
        {
            string vastaus = FizzBuzz.Luku(3);

            Assert.AreEqual("Fizz", vastaus);
        }

        [Test]
        public void TulostaBuzzJosLukuOnViidellaJaollinen()
        {
            string vastaus = FizzBuzz.Luku(5);

            Assert.AreEqual("Buzz", vastaus);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuKuusi()
        {
            string vastaus = FizzBuzz.Luku(6);

            Assert.AreEqual("Fizz", vastaus);
        }

        [Test]
        public void TulostaFizzBuzzJosLukuOnKolmellaJaViidellaJaollinen()
        {
            string vastaus = FizzBuzz.Luku(15);

            Assert.AreEqual("FizzBuzz", vastaus);
        }
    }
}