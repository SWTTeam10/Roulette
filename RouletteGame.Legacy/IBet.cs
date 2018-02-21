namespace RouletteGame.Legacy
{
    public interface IBet
    {
        uint Amount { get; }
        string PlayerName { get; }

        uint WonAmount(Field field);
    }
}