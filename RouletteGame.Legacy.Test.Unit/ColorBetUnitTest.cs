using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class ColorBetUnitTest
    {
        private ColorBet _uut;
        private IField _field;
        private IBet _bet;

        [SetUp]
        public void SetUp()
        {
            _field = Substitute.For<IField>();
            _bet = Substitute.For<IBet>();
        }

        [TestCase(0U)]
        [TestCase(1U)]
        [TestCase(2U)]
        public void Colorbet_amount_test(uint color)
        {
            _uut = new ColorBet("player1", 10, color);
            _field.Color.Returns(color);
            Assert.That(_uut.WonAmount(_field), Is.EqualTo(20U));
        }
    }
}
