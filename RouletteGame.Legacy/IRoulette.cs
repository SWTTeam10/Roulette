namespace RouletteGame.Legacy
{
    public interface IRoulette
    {
        IField GetResult();
        void Spin();
    }
}