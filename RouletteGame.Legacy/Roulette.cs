using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public partial class Roulette : IRoulette
    {
        private List<IField> _fields;
        private IField _result;
        private IFieldFactory _fieldFactory;
        private readonly IGetRandom _getRandom;

        public Roulette(IFieldFactory fieldFactory, IGetRandom getRandom)
        {
            _fieldFactory = fieldFactory;
            _getRandom = getRandom;
            _fields = _fieldFactory.CreateFields();
            _result = _fields[0];
        }

        public void Spin()
        {
            var n = _getRandom.GetRandomNumber(0, 37);
            _result = _fields[n];
        }

        public IField GetResult()
        {
            return _result;
        }
    }
}