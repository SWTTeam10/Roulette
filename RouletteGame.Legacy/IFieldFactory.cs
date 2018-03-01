using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public interface IFieldFactory
    {
        List<IField> CreateFields();
    }
}