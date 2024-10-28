namespace is_twenty_one.api;

public class IsTwentyOneApi
{
    public bool IsTwentyOne(int number) => number == 21;
    public bool IsTwentyOne(float number) => number == 21.0f;
    public bool IsTwentyOne(char number) => number == 21;
}