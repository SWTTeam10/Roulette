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
        private IBet fieldBet;
        private FieldBet uut;

        [SetUp]
        public  void Setup()
        {
            fieldBet = Substitute.For<IBet>();
            
        }

        public void WonAmount_kkk_kkk()
        {
            fieldBet.
           uut.WonAmount();
        

        }
    }
}
