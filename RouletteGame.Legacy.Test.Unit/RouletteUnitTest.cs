using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class RouletteUnitTest
    {
        private Roulette _uut;
        private IGetRandom _randomClass;
        private IField _field;
        private IFieldFactory _fieldFactory;
        private List<IField> _fieldList;
    
        [SetUp]
        public void SetUp()
        {
            _fieldList = new List<IField>();
            _fieldList.Add(Substitute.For<IField>());
            _fieldList.Add(Substitute.For<IField>());
            _fieldList.Add(Substitute.For<IField>());
            _randomClass = Substitute.For<IGetRandom>();
            _fieldFactory = Substitute.For<IFieldFactory>();
            _fieldFactory.CreateFields().Returns(_fieldList);
            _uut = new Roulette(_fieldFactory, _randomClass);
            
        }

        [Test]
        public void Spin_Number0ColorGreen_ResultOK()
        {
            _randomClass.GetRandomNumber(0, 37).Returns(0);

            _fieldList[0].Color.Returns(2U);
            _fieldList[0].Number.Returns(0U);

            _uut.Spin();

            Assert.That(_uut.GetResult().Number,Is.EqualTo(_fieldList[0].Number));
            Assert.That(_uut.GetResult().Color, Is.EqualTo(_fieldList[0].Color));
        }

        [Test]
        public void Spin_Number1ColorRed_ResultOK()
        {
            _randomClass.GetRandomNumber(0, 37).Returns(1);

            _fieldList[1].Color.Returns(0U);
            _fieldList[1].Number.Returns(1U);

            _uut.Spin();

            Assert.That(_uut.GetResult().Number, Is.EqualTo(_fieldList[1].Number));
            Assert.That(_uut.GetResult().Color, Is.EqualTo(_fieldList[1].Color));
        }

        [Test]
        public void Spin_Number2ColorBlack_ResultOK()
        {
            _randomClass.GetRandomNumber(0, 37).Returns(2);

            _fieldList[2].Color.Returns(0U);
            _fieldList[2].Number.Returns(1U);

            _uut.Spin();

            Assert.That(_uut.GetResult().Number, Is.EqualTo(_fieldList[2].Number));
            Assert.That(_uut.GetResult().Color, Is.EqualTo(_fieldList[2].Color));
        }
    }
}
