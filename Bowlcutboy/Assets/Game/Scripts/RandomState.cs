using System;


public class RandomState
{
    private static readonly Random getrandom = new Random(123);

    public RandomState()
    {

    }

    public static Random Getrandom
    {
        get
        {
            return getrandom;
        }
    }

    public int getRandom(int min, int max)
    {
        return getrandom.Next(min, max);
    }
}

