using System;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    public class RouletteGameUnitTest
    {
        private RouletteGame _uut;
        private IRoulette _roulette;
        private IBet _bet;
        private List<IBet> _listBet;

        [SetUp]
        public void SetUp()
        {
            _roulette = Substitute.For<IRoulette>();
            _bet = Substitute.For<IBet>();
            _listBet = Substitute.For<List<IBet>>();
            _uut = new RouletteGame(_roulette, _listBet);

        }

        [Test]
        public void PlaceBets_ClosedForBets_Execeptionthrown()
        {
            _uut.CloseBets();
            Assert.Throws<RouletteGameException>(() => _uut.PlaceBet(_bet));
        }

        [Test]
        public void PlaceBets_OpenForBets_BetRecievedAdd()
        {
            _uut.OpenBets();
            _listBet.Received().Add(_bet);
        }

        [Test]
        public void SpinRoulette_IsSpinRecieved_SpinIsRecived()
        {
            _uut = new RouletteGame(_roulette, new List<IBet>());

            _uut.SpinRoulette();
            _roulette.Received().Spin();
        }
    }
}
