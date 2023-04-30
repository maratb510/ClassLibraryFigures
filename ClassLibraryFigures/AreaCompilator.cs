namespace ClassLibraryFigures
{
    public class AreaCompilator
    {
        public double getTriangleArea(double a, double b, double c)
        {
            double half_P = (a + b + c) / 2;
            double S = Math.Sqrt(half_P * (half_P - a) * (half_P - b) * (half_P - c));
            return S;

        }

        public double getCircleArea(double R)
        {
            double S = R * R * Math.PI;
            return S;
        }
        public bool getIfTriangleisright(double a, double b, double c)
        {
            var max = Math.Max(Math.Max(a, b), Math.Max(b, c));
            if (a==max)
            {
                return isright(max,c,b);
            }
            else if (b==max) { return isright(max, a, c); }
            else { return isright(max, a, b); }
            bool isright(double max, double a, double b)
            {
                return (max * max == a * a + b * b);     
            }

        }
    }
}