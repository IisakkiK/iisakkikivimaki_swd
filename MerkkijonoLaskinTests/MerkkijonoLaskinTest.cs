using MerkkijonoLaskinKonsoli;
using NUnit.Framework;
using System;

namespace MerkkijonoLaskinTests
{
    public class MerkkijonoLaskinTest
    {

        MerkkijonoLaskin laskin;


        [SetUp]
        public void Setup()
        {
            laskin = new MerkkijonoLaskin();
        }

        [Test]
        public void TyhjaMerkkijonoPalauttaaNollan()
        {
            Assert.AreEqual(0, laskin.Laske(""));
        }

        [Test]
        public void LaskinPalauttaaAnnetunArvonJosVainYksiNumero()
        {
            Assert.AreEqual(5, laskin.Laske("5"));
        }

        [Test]
        public void LaskinPalauttaaKahdenPilkullaErotetunLuvunSumman()
        {
            Assert.AreEqual(9, laskin.Laske("5, 4"));
        }
        [Test]
        public void LaskinPalauttaaUseammanPilkullaErotetunLuvunSumman()
        {
            Assert.AreEqual(30, laskin.Laske("5, 4, 10, 11"));
        }
        [Test]
        public void LaskinPalauttaaLukujenSummanNewlineMerkillaaErotettuna()
        {
            Assert.AreEqual(5, laskin.Laske("2\n3"));
            Assert.AreEqual(6, laskin.Laske("1\n2,3"));
            Assert.AreEqual(6, laskin.Laske("1\\n2,3"));
        }

        [Test]
        public void NegatiivinenLukuPienempiKuinNollaAiheuttaaVirheen()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                laskin.Laske("-1");
            });
        }


        [Test]
        public void LaskinEiHuomioTuhannenYlittaviaLukuja()
        {
            Assert.AreEqual(0, laskin.Laske("1001"));
            Assert.AreEqual(4, laskin.Laske("1\n1001,3"));
        }
    }
}