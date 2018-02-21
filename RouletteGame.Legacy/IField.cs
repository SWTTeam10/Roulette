namespace RouletteGame.Legacy
{
    public interface IField
    {
        uint Color { get; }
        bool Even { get; }
        uint Number { get; }

        string ToString();
    }
}