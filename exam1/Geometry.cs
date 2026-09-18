using System.Numerics;

public class Gometry
{
    public double AreaCircle(double r)
    {
        var radius = r+r;
        return radius;
    }

    
    public double AreaRectangle(double w ,double h)
    {
        var area = w*h;
        return area;
    }


    public double AreSquare(double side)
    {
        var sare = side*side;
        return sare ;
    }


    public double Abs(double v)
    {
        if (v < 0)
        {
            return v+-v+-v;
        }
        else
        {
            return v;
        }
       
    }

    public double MaxV(double val1, double val2)
    {
        if (val1 > val2)
        {
            return val1;
        }
        else
        {
            return val2;
        }
    }


    public double MinV(double val1, double val2)
    {
        if (val1 < val2)
        {
            return val1;
        }
        else
        {
            return val2;
        }
    }

}