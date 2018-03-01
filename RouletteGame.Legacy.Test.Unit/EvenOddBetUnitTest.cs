using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class EvenOddBetUnitTest
    {
        private EvenOddBet _uut;
        private IBet _bet;
        private IField _field;
        [SetUp]
        public void SetUp()
        {
            _bet = Substitute.For<IBet>();
            _field = Substitute.For<IField>();
        }

        [TestCase(true, 100)]
        [TestCase(false, 0)]
        public void WonAmount_TrueAndFalse_AmountTimesTwo(bool field, int expresualt)
        {
            _uut = new EvenOddBet("Player 1", 50, true);
            _field.Even.Returns(field);
            Assert.That(_uut.WonAmount(_field), Is.EqualTo(expresualt));
        }
    }
}
