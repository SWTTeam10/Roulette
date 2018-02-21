namespace RouletteGame.Legacy
{
    public interface IRoulette
    {
        Field GetResult();
        void Spin();
    }
}