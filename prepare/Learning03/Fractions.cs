public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction ()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction (int number)
    {
        _top = number;
        _bottom = 1;

    }
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFString()
    {
        string sfraction = $"{_top}/{_bottom}";
        return sfraction;
    }

    public double GetDecimal()
    {
        double dfraction = (double)_top / (double)_bottom;
        return dfraction;
    }

}



