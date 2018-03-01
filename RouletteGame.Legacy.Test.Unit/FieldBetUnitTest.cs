using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class FieldBetUnitTest
    {
        private IBet _fieldBet;
        private IField _field;
        private FieldBet _uut;

        [SetUp]
        public void Setup()
        {
            _fieldBet = Substitute.For<IBet>();
            _field = Substitute.For<IField>();
        }

        [TestCase(100U, 25U, 3600U)]
        [TestCase(200U, 26U, 7200U)]
        public void WonAmount_variousBets_RecievedAmountOK(uint amount, uint number, uint expresult)
        {
            _uut = new FieldBet("Player 3", amount, number);
            _field.Number.Returns(number);
            Assert.That(_uut.WonAmount(_field), Is.EqualTo(expresult));
        }
    }
}
