using System;

namespace RouletteGame.Legacy
{
    public class GetRandom : IGetRandom
    {
        public int GetRandomNumber(int low, int high)
        {
            return new Random().Next(low, high);
        }
    }
}