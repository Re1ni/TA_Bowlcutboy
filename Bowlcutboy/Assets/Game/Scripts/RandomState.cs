using System;


public class RandomState
{
    public static readonly Random getrandom = new Random(123);

    public RandomState()
    {

    }

    public int getRandom(int min, int max)
    {
        return getrandom.Next(min, max);
    }
}

