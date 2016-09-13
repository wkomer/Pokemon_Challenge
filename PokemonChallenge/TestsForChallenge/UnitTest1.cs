using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
namespace TestsForChallenge
{
    [TestFixture]
    public class UnitTest1
    {
        PokemonChallenge.PokemonChallenge pgrm = new PokemonChallenge.PokemonChallenge();

        //Testing Methods for Pokemon Excersise
        [Test]
       public void ReturnForEx1()
        { 
            double total = pgrm.Ex1(6.0,0);

            Assert.AreEqual(6.0, total);

        }

        [Test]
        public void ReturnForEx2()
        {
            double total = pgrm.Ex2(6.0, 0);

            Assert.AreEqual(12.0, total);

        }

        [Test]
        public void ReturnForEx3()
        {
            double total = pgrm.Ex3(6.0,5.0,0,0);

            Assert.AreEqual(9.90, total);

        }

        [Test]
        public void ReturnForEx4()
        {
            double total = pgrm.Ex4(6.0, 5.0, 0, 0);

            Assert.AreEqual(19.80, total);

        }

        [Test]
        public void ReturnForEx5()
        {
            double total = pgrm.Ex5(6.0, 5.0, 0, 0);

          Assert.AreEqual(29.70, total, 001);

        }

        [Test]
        public void ReturnForEx6()
        {
            double total = pgrm.Ex6(6.0, 5.0, 0, 0);

            Assert.AreEqual(15.90, total);

        }

        [Test]
        public void ReturnForEx7()
        {
            double total = pgrm.Ex7(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(12.80, total);

        }

        [Test]
        public void ReturnForEx8()
        {
            double total = pgrm.Ex8(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(18.80, total);

        }

        //Added Test Methods beyond scope

        [Test]
        public void AddedMethod1()
        {
            double total = pgrm.Ad1(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(22.70, total,.001);
        }

        [Test]
        public void AddedMethod2()
        {
            double total = pgrm.Ad2(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(25.60, total, .001);
        }

        [Test]
        public void AddedMethod3()
        {
            double total = pgrm.Ad3(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(31.60, total, .001);
        }

        [Test]
        public void AddedMethod4()
        {
            double total = pgrm.Ad4(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(35.5, total, .001);
        }

        [Test]
        public void AddedMethod5()
        {
            double total = pgrm.Ad5(6.0, 5.0, 5.0, 0, 0);

            Assert.AreEqual(38.4, total, .001);
        }
    }
}
