using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

public class Fractions
{

    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }
    public double GetDecimalValue()
    {
        double decimalValue = (double )_top / _bottom;

        return decimalValue;
    }

}